using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Layout.Absolute.AbsolutePage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbsolutePage : ContentPage
    {
        public AbsolutePage()
        {
            InitializeComponent();
            this.BindingContext = new AbsolutePageModel();
        }
    }
}