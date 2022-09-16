﻿using MyFirstProject.ViewViewModels.Layout;
using MyFirstProject.ViewViewModels.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ControlsView : ContentPage
    {
        public ControlsView()
        {
            InitializeComponent();
            this.BindingContext = new ControlsViewModel();
        }
    }
}