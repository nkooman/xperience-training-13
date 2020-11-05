using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models
{
    public class MediaLibraryViewModel
    {
        public string? LibraryName { get; set; }

        public HashSet<string>? AllowedImageExtensions { get; set; }
    }
}
