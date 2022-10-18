using MyFirstProject.Models;
using MyFirstProject.ViewModels;
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
        public ImageViewModel()
        {
            Title = Titles.ImageViewTitle;
            OnURIClicked = new Command(OnURIClickedAsync);
        }
        private async void OnURIClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ImageURI());
        }
    }
}
