using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls.Picker
{
    class PickerVMViewModel: BaseViewModel
    {
        public ImageSource SubmitButton { get; set; }
        public string _selectedItem = string.Empty;
        public List<String> CarsList { get; set; }

        public PickerVMViewModel()
        {
            Title = Titles.PickerVMViewTitle;

            this.GetEmbeddedImageSrc();
            this.SetCarsList();
        }

        private void GetEmbeddedImageSrc()
        {
            SubmitButton = ImageSource.FromResource("MyFirstProject.Images.buttonsubmit.png");
        }

        public Command OnSubmitClicked
        {
            get
            {
                return new Command(() =>
                {
                   // Application.Current.MainPage.Navigation.PushAsync(new PickerResultsView(_selectedItem, getURLS()));

                });
            }
        }

        private void SetCarsList()
        {
            var cars = Cars.getNames();

            CarsList = (from c in cars
                        select c.Name).ToList();
        }

        public string SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                if (SelectedItem != value)
                    SetProperty(ref _selectedItem, value);
            }

        }
    }
}
