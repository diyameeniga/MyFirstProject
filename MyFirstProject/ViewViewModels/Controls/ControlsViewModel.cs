using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModels.Controls.Entry;
using MyFirstProject.ViewViewModels.Controls.Slider;
using MyFirstProject.ViewViewModels.Controls.Stepper;
using MyFirstProject.ViewViewModels.Controls.Switch;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Layout
{
    public class ControlsViewModel : BaseViewModel
    {
        public ICommand OnSliderClicked { get; set; }
        public ICommand OnStepperClicked { get; set; }
        public ICommand OnSwitchClicked { get; set; }
        public ICommand OnSwitchTwoClicked { get; set; }
        public ICommand OnEntryClicked { get; set; }

        public ControlsViewModel()
        {
            Title = Titles.ControlsViewTitle;

            OnSliderClicked = new Command(OnSliderClickedAsync);
            OnStepperClicked = new Command(OnStepperClickedAsync);
            OnSwitchClicked = new Command(OnSwitchClickedAsync);
            OnSwitchTwoClicked = new Command(OnSwitchTwoClickedAsync);
            OnEntryClicked = new Command(OnEntryClickedAsync);
        }

        private async void OnSliderClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SliderView());
        }

        private async void OnStepperClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new StepperView());
        }

        private async void OnSwitchClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SwitchView());
        }

        private async void OnSwitchTwoClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SwitchTwoView());
        }

        private async void OnEntryClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EntryView());
        }
    }
}
