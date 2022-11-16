using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModels.List.Collection;
using MyFirstProject.ViewViewModels.List.CollectionImages;
using MyFirstProject.ViewViewModels.List.CollectionImages.MovieCollection;
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

        public ICommand OnMovieCollectionClicked { get; set; }
        
        public ListViewViewModel()
        {
            Title = Titles.ListViewTitle;
            OnCollectionClicked = new Command(OnCollectionClickedAsync);
            OnCollectionImageClicked = new Command(OnCollectionImageClickedAsync);
            OnMovieCollectionClicked = new Command(OnMovieCollectionClickedAsync);
        }

        private async void OnCollectionClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Collection_ViewView());
        }

        private async void OnCollectionImageClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new CollectionImageView());
        }

        private async void OnMovieCollectionClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new MovieCollectionView());
        }
    }
}
