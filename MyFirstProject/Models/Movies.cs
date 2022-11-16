using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Models
{
    class Movies
    {
        public string MovieName { get; set; }
        public Movies() { }
        public Movies(string MovieName)
        {
            MovieName = MovieName;
        }

      /*  public ObservableCollection<Movies> MovieCollection
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
        }*/
    }
}
