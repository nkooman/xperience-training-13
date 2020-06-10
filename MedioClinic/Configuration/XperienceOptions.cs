﻿namespace MedioClinic.Configuration
{
    public class XperienceOptions
    {
        public string? SiteName { get; set; }

        public MediaLibraryOptions? MediaLibraryOptions { get; set; }

        public ContentTreeLocationOptions? ContentTreeLocationOptions { get; set; }
    }

    public class MediaLibraryOptions
    {
        public string[]? AllowedImageExtensions { get; set; }

        public string? MedicalCentersLibrary { get; set; }
    }

    public class ContentTreeLocationOptions
    {
        public string? BottomNavigationAliasPath { get; set; }
    }
}
