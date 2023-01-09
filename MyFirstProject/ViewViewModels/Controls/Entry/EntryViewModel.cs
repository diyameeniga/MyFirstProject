﻿using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls.Entry
{
    class EntryViewModel: BaseViewModel
    {
        public ICommand OnEntryClicked { get; }

        private string _entryText = string.Empty;

        public EntryViewModel()
        {
            Title = Titles.EntryViewTitle;
            OnEntryClicked = new Command(OnEntryClickedAsync);
        }

        public string EntryText
        {
            get { return _entryText; }
            
            set
            {
                if (_entryText != value)
                    SetProperty(ref _entryText, value);          
            }
        }

        private async void OnEntryClickedAsync(object obj)
        {
            if(string.IsNullOrEmpty(_entryText.Trim()))
            {
                await Application.Current.MainPage.DisplayAlert(Titles.EntryViewTitle, "Entry can't be empty!", "Ok");
                return;
            }
        }
    }
}
