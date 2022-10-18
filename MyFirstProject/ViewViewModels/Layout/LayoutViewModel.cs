using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModels.Layout.Absolute;
using MyFirstProject.ViewViewModels.Layout.Absolute.AbsolutePage;
using MyFirstProject.ViewViewModels.Layout.Relative;
using MyFirstProject.ViewViewModels.Layout.Relative.RelativePage;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Layout
{
    public class LayoutViewModel : BaseViewModel
    {
        public ICommand OnAbsoluteClicked { get; set; }
        public ICommand OnAbsolutePageClicked { get; set; }
        public ICommand OnRelativeClicked { get; set; }
        public ICommand OnRelativePageClicked { get; set; }
        public LayoutViewModel()
        {
            Title = Titles.LayoutViewTitle;
            OnAbsoluteClicked = new Command(OnAbsoluteClickedAsync);
            OnAbsolutePageClicked = new Command(OnAbsolutePageClickedAsync);
            OnRelativeClicked = new Command(OnRelativeClickedAsync);
            OnRelativePageClicked = new Command(OnRelativePageClickedAsync);
        }

        private async void OnAbsoluteClickedAsync(object obj)
        {
           await Application.Current.MainPage.Navigation.PushAsync(new Absolute_View());
        }

        private async void OnAbsolutePageClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AbsolutePage());
        }
        private async void OnRelativeClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new RelativeView());
        }
        private async void OnRelativePageClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new RelativePage());
        }


    }
}
