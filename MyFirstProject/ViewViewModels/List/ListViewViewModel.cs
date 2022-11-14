using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModels.List.Collection;
using MyFirstProject.ViewViewModels.List.CollectionImages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.List
{
    public class ListViewViewModel: BaseViewModel
    {
        public ICommand OnCollectionClicked { get; set; }

        public ICommand OnCollectionImageClicked { get; set; }

        public ListViewViewModel()
        {
            Title = Titles.ListViewTitle;
            OnCollectionClicked = new Command(OnCollectionClickedAsync);
            OnCollectionImageClicked = new Command(OnCollectionImageClickedAsync);
        }

        private async void OnCollectionClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Collection_ViewView());
        }

        private async void OnCollectionImageClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new CollectionImageView());
        }
    }
}
