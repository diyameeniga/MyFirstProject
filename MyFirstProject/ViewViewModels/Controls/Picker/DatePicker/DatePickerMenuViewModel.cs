using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls.Picker.DatePicker
{
    class DatePickerMenuViewModel: BaseViewModel
    {
        public ImageSource DatePickerXAMLButton { get; set; }
        public ImageSource DatePickerVMButton { get; set; }

        public ICommand OnXAMLClicked { get; }
        public ICommand OnVMClicked { get; }

        public DatePickerMenuViewModel()
        {
            Title = Titles.DatePickerMenuViewTitle;

            GetEmbeddedImageSrc();

            OnXAMLClicked = new Command(OnXAMLClickedAsync);
            OnVMClicked = new Command(OnVMClickedAsync);
        }
        private void GetEmbeddedImageSrc()
        {
            DatePickerXAMLButton = ImageSource.FromResource("MyFirstProject.Images.dpbuttonblue.png");
            DatePickerVMButton = ImageSource.FromResource("MyFirstProject.Images.dpbuttonred.png");
        }

        public async void OnXAMLClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DatePickerView());
        }
        public async void OnVMClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DatePickerVMView());
        }
    }
}
