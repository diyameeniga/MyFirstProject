using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Models
{ 
    public static class Titles
    {
       //MAIN
        public static string MainPageTitle { get; } = "Main Page";
        public static string MainPageSubtitle { get; } = "My Mobile App";
        public static string ListViewTitle { get; } = "List Page";
        public static string LayoutViewTitle { get; } = "Layout Page";
        public static string ImageViewTitle { get; } = "Image Page";
        public static string ControlsViewTitle { get; } = "Controls Page";
        public static string SQLiteViewTitle { get; } = "SQLite Page";

        //LAYOUT TITLES
        public static string AbsolutePageTitle { get; } = "Absolute Page";
        public static string AbsoluteViewTitle { get; } = "Absolute View - Proportional Demo";
        public static string RelativeViewTitle { get; } = "Relative View";
        public static string RelativePageTitle { get; } = "Relative Page";

        //IMAGE TITLES
        public static string ImageURITitle { get; } = "URI Image Page";
        public static string EmbeddedImageTitle { get; } = "Embedded Image View";
        public static string ActivityIndicatorTitle { get; } = "Activity Indicator";

        //LIST TITLES
        public static string CollectionViewTitle { get; } = "Collection View";
        public static string CollectionImageViewTitle { get; } = "Collection View with Images";
        
    }
}
