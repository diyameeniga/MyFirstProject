﻿using MyFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Controls.Picker.DatePicker
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatePickerView : ContentPage
    {
        public DateTime _startDateSelected;
        public DateTime _oStartDateSelected;
        public DateTime _endDateSelected;
        public DateTime _oEndDateSelected;
      
        public DatePickerView()
        {
            InitializeComponent();
            BindingContext = new DatePickerViewModel(); 
        }

        private void StartDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            _startDateSelected = e.NewDate;
            _oStartDateSelected = e.NewDate;
        }

        private void EndDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            _endDateSelected = e.NewDate;
            _oEndDateSelected = e.NewDate;
        }

        public async void Button_Clicked(object sender, EventArgs e)
        {
            string msg = "The start date selected is: " + _startDateSelected.ToShortDateString() + ", " +
                "the end date selected is: " + _endDateSelected.ToShortDateString();

            await Application.Current.MainPage.DisplayAlert(Titles.DatePickerTitle, msg, "Ok");
        }
    }
}