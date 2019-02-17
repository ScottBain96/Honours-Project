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
	public partial class macroNutrientsPage : ContentPage
	{


        int protein;
        int carbs;
        int fats;
        int calories;

        public macroNutrientsPage ()
		{
			InitializeComponent ();
           
        }


        public void PickerSelectedSplit()
        {

            

            calories = Int32.Parse(txtCalories.Text.ToString());
            switch (pickerDiets.SelectedIndex)
            {

                

                //Calculating the % of the calorie value and then dividing it
                //by how many calories there are in 1g of carbs(4), proteins(4), or fats(9)

                case 0:
                    carbs = calories * 50 / 100 / 4;
                    protein = calories * 30 / 100 / 4;
                    fats = calories * 20 / 100 / 9;
                    break;

                case 1:
                    carbs = calories * 60 / 100 / 4;
                    protein = calories * 25 / 100 / 4;
                    fats = calories * 15 / 100 / 9;
                    break;

                case 2:
                    carbs = calories * 40 / 100 / 4;
                    protein = calories * 30 / 100 / 4;
                    fats = calories * 30 / 100 / 9;
                    break;

                case 3:
                    carbs = calories * 25 / 100 / 4;
                    protein = calories * 45 / 100 / 4;
                    fats = calories * 30 / 100 / 9;
                    break;


            

           }

            
        }

        private void Button_Clicked_Split(object sender, EventArgs e)
        {
            try
            {
                PickerSelectedSplit();
                lblResults.Text = ("You Require \n" + carbs + " grams of carbs\n" + protein + " grams of protein\n" + fats + " grams of fat");


            }

            catch
            {
                DisplayAlert("Missing details!", "Please fill in calories box", "Ok");


            }




        }
    }
}