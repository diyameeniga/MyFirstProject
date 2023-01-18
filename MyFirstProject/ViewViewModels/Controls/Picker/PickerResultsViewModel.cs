using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ViewViewModels.Controls.Picker
{
    class PickerResultsViewModel: BaseViewModel
    {
        public PickerResultsViewModel()
        {
            Title = Titles.PickerResultsViewTitle;
        }

      /*  public ObservableCollection<Cars> PersonsCollection { get; }

        private List<Cars> _carsList;

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
    } */
}
}
