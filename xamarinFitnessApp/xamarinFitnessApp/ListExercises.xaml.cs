using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarinFitnessApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListExercises : ContentPage
	{
		public ListExercises ()
		{
            InitializeComponent ();
          
        }

        int workOutValue;
        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            workOutValue = 1;
            await Navigation.PushAsync(new WorkoutPages.Workout1(workOutValue));
        }
        private async void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            workOutValue = 2;
            await Navigation.PushAsync(new WorkoutPages.Workout1(workOutValue));
        }
        private async void ImageButton_Clicked_3(object sender, EventArgs e)
        {
            workOutValue = 3;
            await Navigation.PushAsync(new WorkoutPages.Workout1(workOutValue));
        }
        private async void ImageButton_Clicked_4(object sender, EventArgs e)
        {
            workOutValue = 4;
            await Navigation.PushAsync(new WorkoutPages.Workout1(workOutValue));
        }
        private async void ImageButton_Clicked_5(object sender, EventArgs e)
        {
            workOutValue = 5;
            await Navigation.PushAsync(new WorkoutPages.Workout1(workOutValue));
        }

    }
}