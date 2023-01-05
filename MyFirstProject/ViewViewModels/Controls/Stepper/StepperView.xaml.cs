﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Controls.Stepper
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StepperView : ContentPage
    {
        public StepperView()
        {
            InitializeComponent();
            BindingContext = new StepperViewModel();
        }

        public void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            _rotatingLabel.Rotation = value;
            _displayLabel.Text = string.Format("The Stepper Value is {0}", value);
        }
    }
}