﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Controls.Picker
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PickerVMView : ContentPage
    {
        public PickerVMView()
        {
            InitializeComponent();
            this.BindingContext = new PickerVMViewModel();
        }
    }
}