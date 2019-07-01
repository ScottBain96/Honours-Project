using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcharts;
using SkiaSharp;
using Entry = Microcharts.Entry;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarinFitnessApp.ContentPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartMeUp : ContentPage
    {


        int myValue;
        public StartMeUp()
        {
            InitializeComponent();


            var picker = new Picker { Title = "Select a goal" };


            picker.SelectedIndexChanged += picker_SelectedIndexChanged;



            try
            {

                picker.Items.Add("Weight Loss");
                picker.Items.Add("Maintain Weight");
                picker.Items.Add("Gain Weight");

            }
            catch
            {

            }
            sl.Children.Add(picker);



            picker.SelectedIndexChanged += (sender, args) =>
            {



                if (picker.SelectedIndex == 0)
                {

                    myValue = 0;



                }
                if (picker.SelectedIndex == 1)
                {

                    myValue = 1;

                }

                if (picker.SelectedIndex == 2)
                {

                    myValue = 2;


                }

                if (myValue == 0 || myValue == 2)
                {
                    sl2.IsVisible = true;
                    sl3.IsVisible = false;

                }

                if (myValue == 1)
                {
                    sl2.IsVisible = false;
                    sl3.IsVisible = true;
                }


            }



            ;
        }


        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {






        }

        private void Button_Clicked_Exit(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainMenu());
        }

        private void Button_Clicked_Unit(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConversionsPage());
        }

        private void Button_Clicked_Daily(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BmiPage());
        }

        private void Button_Clicked_Calculate(object sender, EventArgs e)
        {
            
            Chart2.IsVisible = true;
            calculateWeeks();
        }
    

        public void calculateWeeks()
        {
            try {

            btnNext.IsEnabled = true;
            Double initialWeight = Convert.ToDouble(txtInitialWeigh.Text);
            Double finalWeight = Convert.ToDouble(txtFinalWeight.Text);
            double test = initialWeight - ((initialWeight - finalWeight)/2);
            Double TotalWeeks;
          

            if (myValue == 0 && initialWeight > finalWeight)

            {
                TotalWeeks = (initialWeight - finalWeight) / 0.5;
                lblResult.Text = "You require an estimate maximum of " + TotalWeeks.ToString() + " weeks in order to achieve your weight goal, losing a total ammount of: " + (initialWeight - finalWeight).ToString() + " Kilograms";
                    lblNext.Text = "The next you need to do is calculate your daily calories using the Daily Calories calculator in order to be able to consume less calories than you burn. Press " +
               "the Next Button to go there";

                    List<Entry> entries = new List<Entry>
                {
                    new Entry(Convert.ToInt32(initialWeight))
                    {
                        Color = SKColor.Parse("#a256ff"),
                        Label = "Week 0",
                        ValueLabel = initialWeight.ToString(),
                    },

                     new Entry(Convert.ToInt32(test))
                    {
                        Color = SKColor.Parse("#a256ff"),
                        Label = "Week "+ (TotalWeeks/2).ToString(),
                        ValueLabel = test.ToString(),
                    },



                     new Entry(Convert.ToInt32(finalWeight))
                    {
                        Color = SKColor.Parse("#a256ff"),
                        Label = "Week " + TotalWeeks.ToString(),
                        ValueLabel = finalWeight.ToString(),
                    },
                };

                Chart2.Chart = new LineChart { Entries = entries, LabelTextSize = 15 };



            }

            else if (myValue == 2 && finalWeight > initialWeight)
            {
                TotalWeeks = (finalWeight - initialWeight) / 0.5;
                lblResult.Text = "You require an estimate maximum of " + TotalWeeks.ToString() + " weeks in order to achieve your weight goal, gaining a total ammount of: " + (finalWeight - initialWeight).ToString() + " Kilograms";
                    lblNext.Text = "The next you need to do is calculate your daily calories using the Daily Calories calculator in order to be able to consume more calories than you burn. Press " +
                        "the Next Button to go there";
                    
            }
            else
            {
                DisplayAlert("Incorrect details", "Your weight details are incorrect, please submit them again. Also check the goal selector incase you have the wrong type selected", "Okay");
            }
            }
            catch
            {
                DisplayAlert("Incorrect details", "You are missing details or wrong format", "OK");
            }
        }

        private void Button_Clicked_Next(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BmiPage());

        }
    }

    }
