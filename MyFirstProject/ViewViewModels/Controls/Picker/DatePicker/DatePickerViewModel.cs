using MyFirstProject.Models;
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
        public ICommand OnDateButtonClicked { get; }

        public DateTime StartDateSelected;
        public DateTime EndDateSelected;
        public DateTime DefaultDate;
        public DateTime MinDate;
        public DateTime MaxDate;

        public DatePickerViewModel()
        {
            Title = Titles.DatePickerTitle;

            DefaultDate = DateTime.Today;
            MinDate = new DateTime(01, 01, 2019);
            MaxDate = new DateTime(01, 01, 2022);

            GetEmbeddedImageSource();
            OnDateButtonClicked = new Command(OnSubmitClickedAsync);
        }

        private void GetEmbeddedImageSource()
        {
            SubmitButton = ImageSource.FromResource("MyFirstProject.Images.buttonsubmit.png");
        }

        public async void OnSubmitClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DatePickerView());
        }

       
    }
}
