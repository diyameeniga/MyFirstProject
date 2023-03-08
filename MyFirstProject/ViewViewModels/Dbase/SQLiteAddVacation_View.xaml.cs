using MyFirstProject.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Dbase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SQLiteAddVacation_View : ContentPage
    {
        public SQLiteAddVacation_View(Vacation vacation)
        {
            InitializeComponent();
            this.BindingContext = new SQLiteAddVacationViewModel(vacation);
        }
    }
}