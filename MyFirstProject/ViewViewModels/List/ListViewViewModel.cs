using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ViewViewModels.List
{
    public class ListViewViewModel: BaseViewModel
    {
        public ListViewViewModel()
        {
            Title = Titles.ListViewTitle;
        }
    }
}
