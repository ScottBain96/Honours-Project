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
        public ConversionsPage ()
		{
			InitializeComponent ();
            pickerWeight.SelectedIndex = 0;
            pickerHeight.SelectedIndex = 0;
        }

        public void Convert_Weight()
        {


            //Lbs to Kg

            if (pickerWeight.SelectedIndex == 1)
            {             
                weight = Double.Parse(txtWeight.Text.ToString()) / 2.20;
            }

            else
                weight = Double.Parse(txtWeight.Text.ToString()) * 2.20;
                lblWeight.Text = weight.ToString("0,00");

        }

        public void Convert_Height()
        {
            if (pickerHeight.SelectedIndex == 0)
            {
                txtHeightFeet.IsVisible = false;
                txtHeightInches.IsVisible = false;
                txtHeightCm.IsVisible = true;
            }
            else
            {
                txtHeightFeet.IsVisible = true;
                txtHeightInches.IsVisible = true;
                txtHeightCm.IsVisible = false ;

            }

        }

 

  

        private void TxtWeight_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {

                if (pickerWeight.SelectedIndex == 1)
                {
                    weight = Double.Parse(txtWeight.Text.ToString()) / 2.20;
                }

                else
                   weight = Double.Parse(txtWeight.Text.ToString()) * 2.20;
                lblWeight.Text = weight.ToString("0,00");

            
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

            }
            else
            {
                txtHeightCm.IsVisible = true;
                txtHeightFeet.IsVisible = false;
                txtHeightInches.IsVisible = false;

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

                    string result = height.ToString();
                    string myHeight;
                    myHeight = result.Split('.').Last();
                    result = result.Split('.').First();

                    lblHeight.Text = result + "' " + myHeight;

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
            
                

                lblHeight.Text = height.ToString();

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





        //ft and inches to meters
        // height = Double.Parse(txtInch.Text.ToString()) * 2.54;
        // height = height + Double.Parse(txtFt.Text.ToString()) * 30.48;

        //Height to CM
        //height = height / 100;


    }
}