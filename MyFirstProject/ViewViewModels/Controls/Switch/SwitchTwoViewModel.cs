using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls.Switch
{
    class SwitchTwoViewModel: BaseViewModel
    {
        public string _switchValue = "True";
        public string _switchValueTwo = "False";

        public SwitchTwoViewModel()
        {
            Title = Titles.SwitchTwoViewTitle;

        }

        public string SwitchControl
        {
            get { return _switchValue; }

            set
            {
                if (_switchValue != value)
                    SetProperty(ref _switchValue, value);
            }
        }

        public string SwitchControlTwo
        {
            get { return _switchValueTwo; }

            set
            {
                if (_switchValueTwo != value)
                    SetProperty(ref _switchValueTwo, value);
            }
        }
    }
}
