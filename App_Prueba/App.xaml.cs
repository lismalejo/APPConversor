﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App_Prueba.Vistas;

namespace App_Prueba
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new Principal());
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
