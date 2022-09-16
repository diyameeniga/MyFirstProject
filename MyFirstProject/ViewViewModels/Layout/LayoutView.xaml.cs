﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Layout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LayoutView : ContentPage
    {
        public LayoutView()
        {
            InitializeComponent();
            this.BindingContext = new LayoutViewModel();
        }
    }
}