using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Controls.Picker
{
    public partial class PickerResultsView : ContentPage
    {
        public PickerResultsView(string name, string image)
        {
            InitializeComponent();
            this.BindingContext = new PickerResultsViewModel(name, image);
        }
    }
}