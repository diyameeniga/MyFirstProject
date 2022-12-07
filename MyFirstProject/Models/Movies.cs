using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MyFirstProject.Models
{
    public class Movies : BaseViewModel
    {
        public string MovieName { get; set; }
        public Movies() { }
    
        private ObservableCollection<Movies> _movies;
        public Movies(string NameOfMovie)
        {
            MovieName = NameOfMovie;
        }

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

        public static List<Movies> GetMovies()
        {
            return new List<Movies>
            {
                new Movies("The Lord of the Rings"), //need to fix this; when i add or save the names don't show up
                new Movies("Black Panther"),
                new Movies("Iron Man"),
                new Movies("Spiderman"),
                new Movies("Batman")
            };
        }

    }
}
