using MyFirstProject.Models;
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
        DatePickerViewModel VM;
        public DatePickerView()
        {
            InitializeComponent();
            BindingContext = new DatePickerViewModel();
            VM = (DatePickerViewModel)BindingContext;
        }

        private void StartDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            VM.StartDateSelected = e.NewDate;
        }

        private void EndDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            VM.EndDateSelected = e.NewDate;
        }

        
    }
}