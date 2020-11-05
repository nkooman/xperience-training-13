using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

namespace MedioClinic.Widgets
{
    public class ImageWidgetProperties : IWidgetProperties
    {
        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "Media library name", Order = 0)]
        public string? MediaLibraryName { get; set; }

        public Guid? ImageGuid { get; set; }
    }
}
