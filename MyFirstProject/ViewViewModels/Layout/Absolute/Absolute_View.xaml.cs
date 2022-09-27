using MyFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Layout.Absolute
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Absolute_View : ContentPage
    {
        public Absolute_View()
        {
            Title = Titles.LayoutViewTitle;
            InitializeComponent();
            this.BindingContext = new AbsoluteViewModel();
        }
       
    }
}