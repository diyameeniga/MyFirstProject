using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModels.List.CollectionImages.MovieCollection.EditMovies;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.List.CollectionImages.MovieCollection
{
    class MovieCollectionIconsViewModel: BaseViewModel
    {
        private List<Movies> _movie;
        private ObservableCollection<Movies> _movies;

        public ImageSource EditImageSrc { get; set; }
        public ImageSource DeleteImageSrc { get; set; }
       
        public ObservableCollection<Movies> MovieCollection
        {
            get
            {
                return _movies;
            }
            set
            {
                _movies = value;
                OnPropertyChanged();
            }
        }

        public MovieCollectionIconsViewModel()
        {
            Title = Titles.MovieCollectionIconsTitle;
            MovieCollection = new ObservableCollection<Movies>();
            _movie = Movies.GetMovies();
            this.LoadMovies();

            EditImageSrc = ImageSource.FromResource("MyFirstProject.Images.iconsedit.png");
            DeleteImageSrc = ImageSource.FromResource("MyFirstProject.Images.iconsdelete.png");
        }

        private void LoadMovies()
        {
            IsBusy = true;

            try
            {
                _movies.Clear();
                foreach (var p in _movie)
                {
                    MovieCollection.Add(p);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public Command AddCommand
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.MainPage.Navigation.PushAsync(new AddMoviesView());

                    MessagingCenter.Subscribe<Movies>(this, "AddMovies", async (data) =>
                    {
                        MovieCollection.Add(data);

                        MessagingCenter.Unsubscribe<Movies>(this, "AddMovies");
                    });
                });
            }
        }

        public Command<Movies> DeleteCommand
        {
            get
            {
                return new Command<Movies>((Movies mov) =>
                {
                    MovieCollection.Remove(mov);
                });
            }
        }

        public Command<Movies> UpdateCommand
        {
            get
            {
                return new Command<Movies>((Movies mov) =>
                {
                    Application.Current.MainPage.Navigation.PushAsync(new Edit_Movies_View(mov));

                    MessagingCenter.Subscribe<Movies>(this, "UpdateMovies", async (data) =>
                    {
                        var index = MovieCollection.IndexOf(mov);

                        MovieCollection.RemoveAt(index);

                        MovieCollection.Insert(index, data);

                        MessagingCenter.Unsubscribe<Movies>(this, "UpdateMovies");
                    });
                });
            }
        }
    }
}
