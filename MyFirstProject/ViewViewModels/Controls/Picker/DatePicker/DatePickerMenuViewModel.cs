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
        public ImageSource DatePickerButton { get; set; }

        public ICommand OnSubmitClicked { get; }

        public DatePickerMenuViewModel()
        {
            Title = Titles.DatePickerMenuViewTitle;

            GetEmbeddedImageSrc();

            OnSubmitClicked = new Command(OnSubmitClickedAsync);
        }
        private void GetEmbeddedImageSrc()
        {
            DatePickerButton = ImageSource.FromResource("MyFirstProject.Images.dpbuttonblue.png");
        }

        public async void OnSubmitClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DatePickerView());
        }
    }
}
