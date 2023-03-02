using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls.Picker.DatePicker
{
    class DatePickerVMViewModel: BaseViewModel
    {
        public ImageSource SubmitButton { get; set; }

        public DatePickerVMViewModel()
        {
            Title = Titles.DatePickerTitle;

            GetEmbeddedImageSource();
        }

        private void GetEmbeddedImageSource()
        {
            SubmitButton = ImageSource.FromResource("MyFirstProject.Images.buttonsubmit.png");
        }
    }
}
