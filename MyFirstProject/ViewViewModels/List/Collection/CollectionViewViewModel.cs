using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.List.Collection
{
    class CollectionViewViewModel: BaseViewModel
    {
        public ObservableCollection<Person> PersonsCollection { get; }

        private List<Person> _personList;

        public ImageSource ImageSrc { get; set; }

        public CollectionViewViewModel()
        {
            Title = Titles.CollectionViewTitle;

            PersonsCollection = new ObservableCollection<Person>();
            _personList = Person.getNames();
            this.LoadPersons();

            ImageSrc = this.SetImageSrc();
        }

        private void LoadPersons()
        {
            try
            {
                PersonsCollection.Clear();
                foreach (var p in _personList)
                {
                    PersonsCollection.Add(p);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private ImageSource SetImageSrc()
        {
            var imgsrc = new UriImageSource { Uri = new Uri(Images.Image1) };
            imgsrc.CachingEnabled = false;
            imgsrc.CacheValidity = TimeSpan.FromHours(1);

            return imgsrc;
        }
    }
}
