using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;

namespace MyFirstProject.ViewViewModels.List.CollectionImages.MovieCollection
{
    class MovieCollectionViewModel: BaseViewModel
    {

        private List<Movies> _movie;
        public ObservableCollection<Movies> MovieCollection { get; }
        private ObservableCollection<Movies> _movies;

        public MovieCollectionViewModel()
        {
            Title = Titles.MovieCollectionTitle;
            MovieCollection = new ObservableCollection<Movies>();
           // _movie = Movies.GetMovies();
            this.LoadMovies();
        }

        private void LoadMovies()
        {
            try
            {
                MovieCollection.Clear();
                foreach (var p in _movie)
                {
                    MovieCollection.Add(p);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
