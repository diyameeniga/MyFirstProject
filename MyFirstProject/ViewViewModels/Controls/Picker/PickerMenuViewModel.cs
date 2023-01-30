using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls.Picker
{
    class PickerMenuViewModel: BaseViewModel
    {
        public ImageSource PickerButton { get; set; }
        public ImageSource PickerVMButton { get; set; }

        public ICommand OnXAMLSubmitClicked { get; }
        public ICommand OnVMSubmitClicked { get; }

        public PickerMenuViewModel()
        {
            Title = Titles.PickerMenuViewTitle;

            GetEmbeddedImageSrc();

            OnXAMLSubmitClicked = new Command(OnXAMLSubmitClickedAsync);
            OnVMSubmitClicked = new Command(OnPickerVMClickedAsync);
        }

        private void GetEmbeddedImageSrc()
        {
            PickerButton = ImageSource.FromResource("MyFirstProject.Images.buttonred.png");
            PickerVMButton = ImageSource.FromResource("MyFirstProject.Images.buttonblue.png");

        }

        public async void OnXAMLSubmitClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PickerView());
        }

        public async void OnPickerVMClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PickerVMView());
        }

        /*    public Command OnSubmitClicked
            {
                get
                {
                    return new Command(() =>
                    {
                        Application.Current.MainPage.Navigation.PushAsync(new PickerView());

                    });
                }
            }

            public Command OnVMSubmitClicked
            {
                get
                {
                    return new Command(() =>
                    {
                        Application.Current.MainPage.Navigation.PushAsync(new PickerVMView());

                    });
                }
            } */

    }
}
