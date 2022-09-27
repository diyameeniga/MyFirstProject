using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModels.Layout.Absolute;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Layout
{
    public class LayoutViewModel : BaseViewModel
    {
        public ICommand OnAbsoluteClicked { get; set; }
        public LayoutViewModel()
        {
            Title = Titles.LayoutViewTitle;
            OnAbsoluteClicked = new Command(OnAbsoluteClickedAsync);
        }

        private async void OnAbsoluteClickedAsync(object obj)
        {
           await Application.Current.MainPage.Navigation.PushAsync(new Absolute_View());
        }


    }
}
