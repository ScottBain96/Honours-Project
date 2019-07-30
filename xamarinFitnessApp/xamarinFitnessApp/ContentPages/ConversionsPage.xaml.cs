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
	public partial class ConversionsPage : ContentPage
	{


        double weight;
        double height;
        string unitWeight;
        string myHeight;
        public ConversionsPage ()
		{
			InitializeComponent ();
            pickerWeight.SelectedIndex = 0;
            pickerHeight.SelectedIndex = 0;
        }

    

        private void TxtWeight_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {

                if (pickerWeight.SelectedIndex == 1)
                {

                    weight = Double.Parse(txtWeight.Text.ToString()) / 2.20;
                    unitWeight = "Kg";
                    weight = Math.Round(weight, 3);
                }

                if (pickerWeight.SelectedIndex == 0)
                {
                   
                    weight = Double.Parse(txtWeight.Text.ToString()) * 2.20;
                    unitWeight = "Lbs";
               

                }
               
                lblWeight.Text = "Your weight converted is : " + weight.ToString("") + unitWeight;

            
            }
            catch { }


        }

        public void Set_Textboxes()
        {

            if (pickerHeight.SelectedIndex == 1)
            {
                txtHeightCm.IsVisible = false;
                txtHeightFeet.IsVisible = true;
                txtHeightInches.IsVisible = true;
                lblHeightUnit.Text = "Enter Height Details (Feet and Inches)";

            }
            else
            {
                txtHeightCm.IsVisible = true;
                txtHeightFeet.IsVisible = false;
                txtHeightInches.IsVisible = false;
                lblHeightUnit.Text = "Enter Height Details (cm)";
            }


        }

        //CM TO FEET AND INCHES

        private void TxtHeightCm_TextChanged(object sender, TextChangedEventArgs e)
        {

            try
            {



                if (pickerHeight.SelectedIndex == 0)
                {


                    height = Double.Parse(txtHeightCm.Text.ToString()) * 0.3937;
                    height = height / 12;
                    height = Math.Round(height, 3);
                    string result = height.ToString();
                    
                    myHeight = result.Split('.').Last();
                    result = result.Split('.').First();



                   
                    lblHeight.Text = "Your Height converted is : " + result + "'" + myHeight + " (feet and inches)";

                }
                else
                {


                }

            }
            catch
            {

            }

        }

        private void PickerHeight_SelectedIndexChanged(object sender, EventArgs e)
        {
            Set_Textboxes();
        }

        
        private void TxtHeightFeet_TextChanged(object sender, TextChangedEventArgs e)
        {

            try
            {

                calculateFeetInches();


            }

            catch
            {

            }


        }

        public void calculateFeetInches()
        {

            if (txtHeightFeet.Text != null && txtHeightInches.Text != null)
            {




                //ft and inches to meters
                height = Double.Parse(txtHeightInches.Text.ToString()) * 2.54;
                height = height + Double.Parse(txtHeightFeet.Text.ToString()) * 30.48;



                lblHeight.Text = "Your Height converted is : " + height.ToString() + " cm";
                

            }
        }

        private void TxtHeightInches_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                calculateFeetInches();
            }
            catch
            {

            }
        }

        private void PickerWeight_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pickerWeight.SelectedIndex == 0)
            {
                lblunit.Text = "Enter Weight (kg):";
                txtWeight.Placeholder = "kg";
            }
            else
            {
                lblunit.Text = "Enter Weight (lbs):";
                txtWeight.Placeholder = "lbs";
            }

        }
    }
}