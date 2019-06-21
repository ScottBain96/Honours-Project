using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    lblWorkout.Text = "Poisedon";
                    lblw1.Text = "Exercise 1";
                    lblw2.Text = "Exercise 2";
                    lblw3.Text = "Exercise 3";
                    lblw4.Text = "Exercise 4";
                    break;


                case 2:
                    lblWorkout.Text = "Zeus";
                    lblw1.Text = "Exercise 1";
                    lblw2.Text = "Exercise 2";
                    lblw3.Text = "Exercise 3";
                    lblw4.Text = "Exercise 4";
                    break;

                case 3:
                    lblWorkout.Text = "Hades";
                    lblw1.Text = "Exercise 1";
                    lblw2.Text = "Exercise 2";
                    lblw3.Text = "Exercise 3";
                    lblw4.Text = "Exercise 4";
                    break;

                case 4:
                    lblWorkout.Text = "Ares";
                    lblw1.Text = "Exercise 1";
                    lblw2.Text = "Exercise 2";
                    lblw3.Text = "Exercise 3";
                    lblw4.Text = "Exercise 4";
                    break;

                case 5:
                    lblWorkout.Text = "Thor";
                    lblw1.Text = "Exercise 1";
                    lblw2.Text = "Exercise 2";
                    lblw3.Text = "Exercise 3";
                    lblw4.Text = "Exercise 4";
                    break;

            }


        }



        private void Button_Clicked(object sender, EventArgs e)
        {

           
                Device.StartTimer(TimeSpan.FromSeconds(5), () =>
                {
                    // Do something
                    
                    

                   Navigation.PushAsync(new MainMenu());
                
                    return false ; // True = Repeat again, False = Stop the timer
                  
                });

             


        }
    }
}