using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls.Picker
{
    class PickerVMViewModel: BaseViewModel
    {
        public ICommand OnSubmitClicked { get; }
        public ImageSource SubmitButton { get; set; }
        public List<String> CarsList { get; set; }
        public string _selectedItem = string.Empty;

        public PickerVMViewModel()
        {
            Title = Titles.PickerVMViewTitle;
            GetEmbeddedImageSrc();
            OnSubmitClicked = new Command(OnSubmitClickedAsync);
            GetCarsList();
        }

        private void GetEmbeddedImageSrc()
        {
            SubmitButton = ImageSource.FromResource("MyFirstProject.Images.buttonsubmit.png");
        }

        private void GetCarsList()
        {
            List<Cars> names = Cars.getCars();

            var cars = Cars.getCars();

            CarsList = (from c in cars
                        select c.Car).ToList();
        }

        public string SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                if (_selectedItem != value)
                    SetProperty(ref _selectedItem, value);
            }
        }

        private async void OnSubmitClickedAsync(object obj)
        {
            if (String.IsNullOrEmpty(_selectedItem))
            {
                await Application.Current.MainPage.DisplayAlert(Titles.PickerVMViewTitle, "A selection must be made!", "Ok");
                return;
            }

            List<Cars> cars = Cars.getCars();

            var result = cars.FirstOrDefault(x => x.Car.Equals(_selectedItem));

            await Application.Current.MainPage.Navigation.PushAsync(new PickerResultsView(result.Car, result.Image));
        }
    }

    /*  public ImageSource SubmitButton { get; set; }
      public string _selectedItem = string.Empty;
      public ImageSource _selectedCar { get; set; }
      public List<String> CarsList { get; set; }
     // public ICommand

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

      private ImageSource FindImage()
      {
          foreach(Cars c in Cars.getURLs())
          {
              if(c.Name.Equals(_selectedItem))
              {
                  return c.URL;
              }
          }
          return null;
      }
      public Command OnSubmitClicked
      {
          get
          {
              return new Command(() =>
              { 
                 Application.Current.MainPage.Navigation.PushAsync(new PickerResultsView(_selectedItem, this.FindImage()));
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
      } */
}

