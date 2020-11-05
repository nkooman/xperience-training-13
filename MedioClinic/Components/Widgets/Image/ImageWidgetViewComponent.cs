using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

using Kentico.PageBuilder.Web.Mvc;

using XperienceAdapter.Repositories;
using Business.Configuration;
using Business.Models;
using MedioClinic.Widgets;

[assembly: RegisterWidget(ImageWidgetViewComponent.Identifier, typeof(ImageWidgetViewComponent), "Image", Description = "Displays an image.", IconClass = "icon-image")]

namespace MedioClinic.Widgets
{
    public class ImageWidgetViewComponent : ViewComponent
    {
        public const string Identifier = "MedioClinic.Widget.Image";

        private readonly IOptionsMonitor<XperienceOptions> _optionsMonitor;

        private readonly IMediaFileRepository _mediaFileRepository;

        public ImageWidgetViewComponent(IOptionsMonitor<XperienceOptions> optionsMonitor, IMediaFileRepository mediaFileRepository)
        {
            _optionsMonitor = optionsMonitor ?? throw new ArgumentNullException(nameof(optionsMonitor));
            _mediaFileRepository = mediaFileRepository ?? throw new ArgumentNullException(nameof(mediaFileRepository));
        }

        public async Task<IViewComponentResult> InvokeAsync(ComponentViewModel<ImageWidgetProperties> widgetProperties)
        {
            bool hasImage;
            var mediaLibraryName = widgetProperties.Properties.MediaLibraryName;
            var imageGuid = widgetProperties.Properties.ImageGuid;
            ImageWidgetViewModel? viewModel = default;

            if (imageGuid != null && !string.IsNullOrEmpty(mediaLibraryName))
            {
                hasImage = true;
                var imageUrl = (await _mediaFileRepository.GetMediaFileDtoAsync(imageGuid.Value))?.MediaFileUrl;

                viewModel = new ImageWidgetViewModel
                {
                    HasImage = hasImage,
                    ImageUrl = imageUrl!,

                    MediaLibraryViewModel = new MediaLibraryViewModel
                    {
                        AllowedImageExtensions = _optionsMonitor?.CurrentValue?.MediaLibraryOptions?.AllowedImageExtensions.ToHashSet(),
                        LibraryName = mediaLibraryName
                    }
                };
            }

            return View("~/Components/Widgets/Image/_ImageWidget.cshtml", viewModel);
        }
    }
}
