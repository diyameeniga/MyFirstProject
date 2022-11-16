using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.List.CollectionImages
{
    class CollectionImageViewModel: BaseViewModel
    {
        public ObservableCollection<Person> PersonsCollection { get; }

        private List<Person> _personList;

        public CollectionImageViewModel()
        {
            Title = Titles.CollectionImageViewTitle;

            PersonsCollection = new ObservableCollection<Person>();
            _personList = Person.getURLs();
            this.LoadPersons();
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
    }
}