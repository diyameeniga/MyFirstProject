using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Controls.Entry
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultsView : ContentPage
    {
        public ResultsView(string text)
        {
            InitializeComponent();
            this.BindingContext = new ResultsViewModel();
            ResultText.Text = text;
        }
    }
}