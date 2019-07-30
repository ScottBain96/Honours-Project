using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarinFitnessApp.WorkoutPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Workout1Started : ContentPage
    {

        //counter for current image etc
        int CounterCurrent = 0;

        //counter to end workout
        int CounterEnd = 0;

        //which workout it is
        int WorkoutValue;

        //first next button click for initial time
        int activateTime;
        
        //to save times, initial and final.
        string time1;
        string time2;
    

      

        public Workout1Started(int workoutValue)
        {
            InitializeComponent();
            WorkoutValue = workoutValue;
            
          
         
        }


        private void BtnStart_Clicked(object sender, EventArgs e)
        {

            CounterCurrent++;
            CounterEnd++;
            activateTime++;

            lblTitle.Text = "Goodluck!";

            //if first time clicking next, save current time for Stopwatch

            if (activateTime == 1)
            {
                time1 = DateTime.Now.ToLongTimeString();

            
            }

            //poseidon Workout
            if (WorkoutValue == 1) {

                myWorkout1();
            }
            //
            else if (WorkoutValue == 2)
            {
                myWorkout2();
            }
            else if (WorkoutValue == 3)
            {
                myWorkout3();
            }
            else if (WorkoutValue == 4)
            {
                myWorkout4();
            }
            else if (WorkoutValue == 5)
            {
                myWorkout5();
            }


        }

        //method to call when workout ends.
        public void endWorkout()
        {
            btnEnd.IsEnabled = true;
            btnStart.IsEnabled = false;

        }


        private void BtnEnd_Clicked(object sender, EventArgs e)
        {

            //Ending time being saved, difference calculated to gain the total ammount of time spent

            time2 = DateTime.Now.ToLongTimeString();
            TimeSpan timespan = DateTime.Parse(time2) - DateTime.Parse(time1);
        
            DisplayAlert("Workout Ended", "Your time for completition was: " + timespan.ToString(), "Ok");
            Navigation.PushAsync(new MainMenu());
        }


        //LIST OF WORKOUTS, CREATED THEM LIKE THIS TO BE ABLE TO MAKE DIFFERENT 
        //AMMOUNTS OF SETS RATHER THAN ALL FOLLOWING SAME PATTERN.
        //SEPARATED THEM IN FUNCTIONS EASIER TO EDIT AND ADD MORE

        //Poseidon workout 3 sets, 4 exercises
        public void myWorkout1() {

            if (CounterCurrent > 4)
            {
                CounterCurrent = 1;
            }

            if (CounterCurrent == 1)
            {
                lblCurrentExercise.Text = "4 push-ups";
                currentImage.Source = "Pushups.jpg";
            }
            else if (CounterCurrent == 2)
            {
                lblCurrentExercise.Text = "10 sit-ups";
                currentImage.Source = "situps.jpg";
               


            }
            else if (CounterCurrent == 3)
            {

                lblCurrentExercise.Text = "10 Squats";
                currentImage.Source = "squats.jpg";
            }
            else if (CounterCurrent == 4)
            {
                lblCurrentExercise.Text = "30 seconds plank";
                currentImage.Source = "plank.jpg";
            }
          
            if (CounterEnd == 12)
            {
                endWorkout();
            }


        }

        //zeus workout 3 sets, 4 exercises
        public void myWorkout2()
        {
            if (CounterCurrent > 4)
            {
                CounterCurrent = 1;
            }

            if (CounterCurrent == 1)
            {
                lblCurrentExercise.Text = "10 push-ups";
                currentImage.Source = "Pushups.jpg";
            }
            else if (CounterCurrent == 2)
            {
                lblCurrentExercise.Text = "10 Mountain Climbers";
                currentImage.Source = "mountain.jpg";
            }
            else if (CounterCurrent == 3)
            {

                lblCurrentExercise.Text = "10 Burpees";
                currentImage.Source = "burpees.jpg";
            }
            else if (CounterCurrent == 4)
            {
                lblCurrentExercise.Text = "30 Squats";
                currentImage.Source = "squats.jpg";
            }
            if (CounterEnd == 12)
            {
                endWorkout();
            }

        }

        //Hades workout 5 sets, 5 exercises
        public void myWorkout3()
        {
            if (CounterCurrent > 5)
            {
                CounterCurrent = 1;
            }

            if (CounterCurrent == 1)
            {
                lblCurrentExercise.Text = "20 push-ups";
                currentImage.Source = "Pushups.jpg";
            }
            else if (CounterCurrent == 2)
            {
                lblCurrentExercise.Text = "20 sit-ups";
                currentImage.Source = "situps.jpg";
            }
            else if (CounterCurrent == 3)
            {

                lblCurrentExercise.Text = "20 Mountain Climbers";
                currentImage.Source = "mountain.jpg";
            }
            else if (CounterCurrent == 4)
            {
                lblCurrentExercise.Text = "20 Burpees";
                currentImage.Source = "burpees.jpg";
            }

            else if (CounterCurrent == 5)
            {
                lblCurrentExercise.Text = "20 Squats";
                currentImage.Source = "squats.jpg";
            }


            if (CounterEnd == 25)
            {
                endWorkout();
            }
        }

        //Ares workout 3sets, 4 exercises
        public void myWorkout4()
        {
            if (CounterCurrent > 4)
            {
                CounterCurrent = 1;
            }

            if (CounterCurrent == 1)
            {
                lblCurrentExercise.Text = "10 pull-ups";
                currentImage.Source = "pullups.jpg";
            }
            else if (CounterCurrent == 2)
            {
                lblCurrentExercise.Text = "10 chin-ups";
                currentImage.Source = "chinups.jpg";
            }
            else if (CounterCurrent == 3)
            {

                lblCurrentExercise.Text = "10 push-ups";
                currentImage.Source = "Pushups.jpg";
            }
            else if (CounterCurrent == 4)
            {
                lblCurrentExercise.Text = "30 seconds plank";
                currentImage.Source = "plank.jpg";
            }
            if (CounterEnd == 12)
            {
                endWorkout();
            }
        }
        
        //Thor workout 3sets, 4 exercises
        public void myWorkout5()
        {
            if (CounterCurrent > 4)
            {
                CounterCurrent = 1;
            }

            if (CounterCurrent == 1)
            {
                lblCurrentExercise.Text = "20 push-ups";
                currentImage.Source = "Pushups.jpg";
            }
            else if (CounterCurrent == 2)
            {
                lblCurrentExercise.Text = "20 sit-ups";
                currentImage.Source = "situps.jpg";
            }
            else if (CounterCurrent == 3)
            {

                lblCurrentExercise.Text = "10 pull-ups";
                currentImage.Source = "pullups.jpg";
            }
            else if (CounterCurrent == 4)
            {
                lblCurrentExercise.Text = "20 mountain climbers";
                currentImage.Source = "mountain.jpg";
            }
            if (CounterEnd == 12)
            {
                endWorkout();
            }
        }


    }
}