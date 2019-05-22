using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcharts;
using SkiaSharp;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Entry = Microcharts.Entry;

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
            pickerDiets.SelectedIndex = 0;
           
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



        public void Create_Donut_Graph()
        {


            List<Entry> entries = new List<Entry>
        {
            new Entry(carbs)
            {
                Color = SKColor.Parse("#a256ff"),
                Label = "Carbs",
                ValueLabel = carbs.ToString()
            },


             new Entry(fats)
            {
                Color = SKColor.Parse("#f44141"),
                Label = "Fats",
                ValueLabel = fats.ToString()
            },



              new Entry(protein)
            {
                Color = SKColor.Parse("#429ef4"),
                Label = "Proteins",
                ValueLabel = protein.ToString()
                
            }
        };
            Chart2.Chart = new BarChart { Entries = entries };




        }



        private void Button_Clicked_Split(object sender, EventArgs e)
        {
            try
            {
                PickerSelectedSplit();
                lblResults.Text = ("You Require: \n" + carbs + " grams of carbs\n" + protein + " grams of protein\n" + fats + " grams of fat");
                Create_Donut_Graph();


            }

            catch
            {
                DisplayAlert("Missing details!", "Please fill in calories box", "Ok");


            }




        }

        private void Button_Clicked_Help(object sender, EventArgs e)
        {
            DisplayAlert("Help info", "Calories can be obtained from the BMI calculator from the previous page. Splits options are % of carbs, proteins, fats in that order", "Ok");
        }
    }
}