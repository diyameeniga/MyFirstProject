using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Controls.Switch
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwitchTwoView : ContentPage
    {
        public SwitchTwoView()
        {
            InitializeComponent();
            this.BindingContext = new SwitchTwoViewModel();
        }

    }
}