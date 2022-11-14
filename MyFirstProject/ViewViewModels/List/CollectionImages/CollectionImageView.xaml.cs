﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.List.CollectionImages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionImageView : ContentPage
    {
        public CollectionImageView()
        {
            InitializeComponent();
            this.BindingContext = new CollectionImageViewModel();
        }
    }
}