using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls.Picker
{
    class PickerViewModel: BaseViewModel
    {
        public ImageSource SubmitButton { get; set; }

        public PickerViewModel()
        {
            Title = Titles.PickerViewTitle;

            GetEmbeddedImageSrc();
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
                    Application.Current.MainPage.Navigation.PushAsync(new PickerResultsView());

                });
            }
        }
    }
}
