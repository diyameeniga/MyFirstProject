﻿using System;
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

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
