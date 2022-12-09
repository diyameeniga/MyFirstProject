using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.List.CollectionImages.MovieCollection
{
    class AddMovieViewModel: BaseViewModel
    {
        public ICommand SaveBtnClicked { get; set; }
        private string _movieText = string.Empty;
        
        public AddMovieViewModel()
        {
            Title = Titles.AddTitle;

            SaveBtnClicked = new Command(PerformSave);
        }

        public string MovieText
        {
            get 
            { 
                return _movieText; 
            }
            set
            {
                if (_movieText != value)
                    SetProperty(ref _movieText, value);
            }
        }

        private void PerformSave()
        {
            if (string.IsNullOrEmpty(_movieText.Trim()))
            {
                Application.Current.MainPage.DisplayAlert(Titles.AddTitle, Msgs.NotEmpty, "Ok");
                return;
            }

            Movies movies = new Movies();
            movies.MovieName = _movieText;

            MessagingCenter.Send<Movies>(movies, "AddMovies");
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
