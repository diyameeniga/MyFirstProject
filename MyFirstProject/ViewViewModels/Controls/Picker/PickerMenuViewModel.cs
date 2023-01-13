using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls.Picker
{
    class PickerMenuViewModel: BaseViewModel
    {
        public ImageSource PickerButton { get; set; }
        public PickerMenuViewModel()
        {
            Title = Titles.PickerMenuViewTitle;

            GetEmbeddedImageSrc();
        }

        private void GetEmbeddedImageSrc()
        {
            PickerButton = ImageSource.FromResource("MyFirstProject.Images.buttonred.png");
        }

        public Command OnSubmitClicked
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.MainPage.Navigation.PushAsync(new PickerView());

                });
            }
        }

    }
}
