using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MyFirstProject.ViewViewModels.Controls.Picker
{
    class PickerResultsViewModel: BaseViewModel
    {
        public List<String> CarsList { get; set; }

        public PickerResultsViewModel()
        {
            Title = Titles.PickerResultsViewTitle;
        }
    }
}
