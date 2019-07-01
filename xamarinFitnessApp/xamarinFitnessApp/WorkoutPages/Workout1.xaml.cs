using Plugin.LocalNotifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarinFitnessApp.WorkoutPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Workout1 : ContentPage
	{
        int WorkoutValue;
        //int timer = 5;
        public Workout1 (int parameter)
		{
			InitializeComponent ();
            WorkoutValue = parameter;
          
            setWorkout();
          //  timerx.Text = timer.ToString();

        }

        public void setWorkout()
        {

            switch (WorkoutValue)
            {

                case 1:
                    lblWorkout.Text = "Poisedon Workout: 3 sets, 4 exercises";
                    lblw1.Text = "Pushups x12";
                    lblw2.Text = "SitUps x30";
                    lblw3.Text = "Squats x30";
                    lblw4.Text = "Planks 90seconds";
                    break;


                case 2:
                    lblWorkout.Text = "Zeus Workout: 3 sets, 4 exercises";
                    lblw1.Text = "Pushups x30";
                    lblw2.Text = "Mountain Climbers x30";
                    lblw3.Text = "Burpees x30";
                    lblw4.Text = "Squats x90";
                    break;

                case 3:
                    lblWorkout.Text = "Hades Workout: 5 sets, 5 exercises";
                    lblw1.Text = "PushUps x100";
                    lblw2.Text = "SitUps x100";
                    lblw3.Text = "Mountain Climbers x100";
                    lblw4.Text = "Burpees x100";
                    lblw5.Text = "Squats x100";
                    break;

                case 4:
                    lblWorkout.Text = "Ares Workout: 3 sets, 4 exercises";
                    lblw1.Text = "Pullups x30";
                    lblw2.Text = "Chinups x30";
                    lblw3.Text = "Pushups x30";
                    lblw4.Text = "Planks 90seconds";
                    break;

                case 5:
                    lblWorkout.Text = "Thor Workout: 3 sets, 4 exercises";
                    lblw1.Text = "Pushups x60";
                    lblw2.Text = "Situps x60";
                    lblw3.Text = "PullUps x30";
                    lblw4.Text = "Mountain Climbers x60";
                    break;

            }


        }



        private void Button_Clicked(object sender, EventArgs e)
        {
      

            Navigation.PushAsync(new WorkoutPages.Workout1Started(WorkoutValue));


        }
    }
}