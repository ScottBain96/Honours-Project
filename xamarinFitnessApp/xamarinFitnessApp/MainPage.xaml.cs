﻿using Plugin.LocalNotifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using xamarinFitnessApp.ContentPages;

namespace xamarinFitnessApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        
        }

 


        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainMenu());

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StartMeUp());
        }
    }
}
