﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OmaXamarin2021
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new IoTPage());
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
