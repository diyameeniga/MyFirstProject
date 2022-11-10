using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.List.Collection
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Collection_ViewView : ContentPage
    {
        public Collection_ViewView()
        {
            InitializeComponent();
            this.BindingContext = new CollectionViewViewModel();
        }
    }
}