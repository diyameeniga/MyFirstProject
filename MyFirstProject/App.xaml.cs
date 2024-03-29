﻿using MyFirstProject.Patterns.Repositories;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Get<ISQLite>().GetConnectionWithCreateDatabase();

            MainPage = new NavigationPage(new MainPage());
        }
    }
}
