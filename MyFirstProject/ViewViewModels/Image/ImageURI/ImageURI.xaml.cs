﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Image.ImageURI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageURI : ContentPage
    {
        public ImageURI()
        {
            InitializeComponent();
            this.BindingContext = new ImageURIModel();
        }
    }
}