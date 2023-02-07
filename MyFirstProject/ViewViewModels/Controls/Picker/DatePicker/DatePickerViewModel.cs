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
        public string _startDateSelected = string.Empty;
        public string _oStartDateSelected = string.Empty;
        public string _endDateSelected = string.Empty;
        public string _oEndDateSelected = string.Empty;

        public ICommand OnSubmitClicked { get; }

        public DatePickerViewModel()
        {
            Title = Titles.DatePickerTitle;

            OnSubmitClicked = new Command(OnSubmitClickedAsync);
        }

        private void StartDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
           // _startDateSelected = e.NewDate;
           // _oStartDateSelected = e.OldDate;
        }

        private void EndDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
         //   _endDateSelected = e.NewDate;
          //  _oEndDateSelected = e.OldDate;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //string msg = "The start day selected is: " + _startDateSelected.ToShortDateString() + "," +
           //     "the end date selected is: " + _endDateSelected.ToShortDateString();

           // await Application.Current.MainPage.DisplayAlert(Titles.DatePickerTitle, msg, "Ok");
        }

        public async void OnSubmitClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DatePickerView());
        }
    }
}