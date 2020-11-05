using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Business.Models;
using Kentico.Content.Web.Mvc;

namespace MedioClinic.Widgets
{
    public class ImageWidgetViewModel
    {
        public bool HasImage { get; set; }

        public IMediaFileUrl? ImageUrl { get; set; }

        public MediaLibraryViewModel? MediaLibraryViewModel { get; set; }
    }
}
