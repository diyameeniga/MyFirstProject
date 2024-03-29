﻿using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls.Picker.DatePicker
{
    class DatePickerViewModel: BaseViewModel
    {
        public ImageSource SubmitButton { get; set; }

        public DatePickerViewModel()
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
