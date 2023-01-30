using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls.Picker
{
    class PickerResultsViewModel: BaseViewModel
    {
        public ImageSource ImageSrc { get; set; }
        public string _pickerSelection;

        public PickerResultsViewModel(string name, string image)
        {
            Title = Titles.PickerResultsViewTitle;
            ImageSrc = this.SetImageSrc(image);
            _pickerSelection = name;
        }

        private ImageSource SetImageSrc(string img)
        {
            var imgsrc = new UriImageSource { Uri = new Uri(img) };
            imgsrc.CachingEnabled = false;

            return imgsrc;
        }

        public string PickerSelection
        {
            get { return _pickerSelection; }
        }
    }
}
