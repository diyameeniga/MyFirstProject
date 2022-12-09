using MyFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.List.CollectionImages.MovieCollection.EditMovies
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Edit_Movies_View : ContentPage
    {
        public Edit_Movies_View(Movies mov)
        {
            InitializeComponent();
            BindingContext = new EditMoviesViewModel();
            Title.Text = mov.MovieName;
        }
    }
}