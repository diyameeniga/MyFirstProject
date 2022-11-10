using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModels.Image.ActivityIndicator;
using MyFirstProject.ViewViewModels.Image.EmbeddedImage;
using MyFirstProject.ViewViewModels.Image.ImageURI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Layout
{
    public class ImageViewModel : BaseViewModel
    {
        public ICommand OnURIClicked { get; set; }
        public ICommand OnEmbeddedClicked { get; set; }
        public ICommand OnActivityClicked { get; set; }
        public ImageViewModel()
        {
            Title = Titles.ImageViewTitle;
            OnURIClicked = new Command(OnURIClickedAsync);
            OnEmbeddedClicked = new Command(OnEmbeddedClickedAsync);
            OnActivityClicked = new Command(OnActivityClickedAsync);
        }
        private async void OnURIClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ImageURI());
        }
        private async void OnEmbeddedClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EmbeddedImageView());
        }
        private async void OnActivityClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ActivityIndicatorView());
        }
    }
}
