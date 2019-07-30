﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarinFitnessApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainMenu : ContentPage
	{
		public MainMenu ()
		{
			InitializeComponent ();
		}



        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            
            Navigation.PushAsync(new ListExercises());
        }


        private void ImageButton_Clicked_exercises(object sender, EventArgs e)
        {
            
            Navigation.PushAsync(new exercisesAvailable());
        }

       

        private void ImageButton_Clicked_Tools(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ToolsPage());
        }


    }
}