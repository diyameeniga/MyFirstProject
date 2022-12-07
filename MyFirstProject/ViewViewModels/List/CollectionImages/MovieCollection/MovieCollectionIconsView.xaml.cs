using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.List.CollectionImages.MovieCollection
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MovieCollectionIconsView : ContentPage
    {
        public MovieCollectionIconsView()
        {
            InitializeComponent();
            this.BindingContext = new MovieCollectionIconsViewModel();
        }
    }
}