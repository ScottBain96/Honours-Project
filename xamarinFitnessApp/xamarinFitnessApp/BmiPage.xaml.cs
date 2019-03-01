﻿using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Entry = Microcharts.Entry; //change Entry to Microcharts.Entry
using System.IO;

namespace xamarinFitnessApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]

	public partial class BmiPage : ContentPage

	{

        private UserDataAccess dataAccess;

        //variables to be used in the functions

        double bmi;
        double weight;
        double height;
      
        int gender;
        double intensity;
        int results;
        
     



		public BmiPage ()
		{
            

            InitializeComponent ();
            this.dataAccess = new UserDataAccess();
            int myId =1;
            var picker = new Picker { Title = "Select a Profile" };
            picker.SelectedIndexChanged += picker_SelectedIndexChanged;
            try
            {
               
                picker.Items.Add(this.dataAccess.GetCustomer(1).UserName);
                picker.Items.Add(this.dataAccess.GetCustomer(2).UserName);
               // picker.Items.Add(this.dataAccess.GetCustomer(3).UserName);


             

            }
            catch
            {
                
            }
            sl.Children.Add(picker);


            // If select

            //  txtAge.Text = this.dataAccess.GetCustomer(myId).CompanyName;
            pickerUnit.SelectedIndex = 0;
            pickerGender.SelectedIndex = 0;
            pickerActivity.SelectedIndex = 0;



            //    //android
            //    string dbPath = Path.Combine(
            //Environment.GetFolderPath(Environment.SpecialFolder.Personal),
            //"database.db3");


            //    var db = new SQLiteConnection(dbPath);


        }



        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {


         

       

        }

        private  async void  Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new profilesView());
        }



        public void Convert_Metric_BMI() {

         
                weight = Double.Parse(txtWeightKg.Text.ToString());
                //Heigh is CM so divide by 100 for meters
                height = Double.Parse(txtCm.Text.ToString());
                height = height / 100;

        }


      

        //Set variable gender to the values required for the formula (5 for male, -161 for female)

        public void SetGenderValue()
        {
            if (pickerGender.SelectedIndex == 0)
            {

                gender = 5;

            }
            
            else
            {
                gender = -161;

            }

            setAge.Text = gender.ToString();

        }

       

        //Set variable intensity depending on the activity level, values provided by the formula
        public void SetActivityLevel()
        {

           // string pickerValue;
           // pickerValue = pickerActivity.SelectedItem.ToString();

            

            switch (pickerActivity.SelectedIndex)
            {

                case 0:
                    intensity = 1.2;
                    break;


                case 1:
                    intensity = 1.375;
                    break;

                case 2:
                    intensity = 1.55;
                    break;

                case 3:
                    intensity = 1.725;
                    break;

            }

            setAct.Text = intensity.ToString("0.000");


        }

        //Conversions to imperial units
        public void Convert_Imperial_BMI()
        {

            if (pickerUnit.SelectedIndex == 1)
            {
                
                //ft and inches to meters
                height = Double.Parse(txtInch.Text.ToString()) * 2.54;
                height = height + Double.Parse(txtFt.Text.ToString()) * 30.48;

                //Height to CM
                height = height / 100;

                //Lbs to Kg
                weight = Double.Parse(txtWeightLbs.Text.ToString()) / 2.20;



            }
        }


        //BMI formula calculation
        
        public void CalculateFormulaBMI()
        {
            bmi = weight / height;
            bmi = bmi / height;
            numberBMI.Text = bmi.ToString("0.00");


        }

        //Daily calorie formula

        public void CalculateFormulaCals()
        {
            SetGenderValue();
            SetActivityLevel();
            int age = Int32.Parse(txtAge.Text.ToString());
            height = height * 100;
            results = (int) ((10 * weight + 6.25 * height - 5 * age + gender) * intensity);
            setAge.Text = results.ToString("0,00");
           

        }

        //Determin range of weight with BMI, Might change to case statements

        public void Info_results_BMI()
        {

            if (bmi < 18.5)


            {

                Results.Text = "You are in the Underweight range";
            }


            if (bmi > 18.5 && bmi < 25)


            {
                Results.Text = "You are in the Normal range";

            }


            if (bmi > 25)


            {

                Results.Text = "You are in the Overweight range";

            }


        }

       
        //Run all the functions required, try-catch for error handling

        private void Button_Calculate_Clicked(object sender, EventArgs e)
        {


            try { 
            

            if (pickerUnit.SelectedIndex == 0)
            {



                Convert_Metric_BMI();



            }

            if (pickerUnit.SelectedIndex == 1)
                {


                Convert_Imperial_BMI();


            }


                CalculateFormulaBMI();
                Info_results_BMI();
                CalculateFormulaCals();
               


            }
            catch
            {
                DisplayAlert("Missing Details", "Please fill in all details", "OK");

            }

        }

    
        //Enabling and disabling controls regarding the selection of Unit system 

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            //Metric entries

            if (pickerUnit.SelectedIndex == 0)
            {

                //weight KG
                txtWeightKg.IsEnabled = true;
                txtWeightKg.IsVisible = true;
                lblKg.IsVisible = true;
                

                //weight LBs
                txtWeightLbs.IsEnabled = false;
                txtWeightLbs.IsVisible = false;
                lblLbs.IsVisible = false;

                //height cm
                txtCm.IsEnabled = true;
                txtCm.IsVisible = true;
                lblCm.IsVisible = true;
                
                //height ft
                txtFt.IsEnabled = false;
                txtFt.IsVisible = false;
                lblFt.IsVisible = false;

                //height inch
                txtInch.IsEnabled = false;
                txtInch.IsVisible = false;
                lblInch.IsVisible = false;         
              
            } 

            //Imperial Entries
            else
            {
                txtWeightKg.IsEnabled = false;
                txtWeightKg.IsVisible = false;
                lblKg.IsVisible = false;

                txtWeightLbs.IsEnabled = true;
                txtWeightLbs.IsVisible = true;
                lblLbs.IsVisible = true;

                txtCm.IsEnabled = false;
                txtCm.IsVisible = false;
                lblCm.IsVisible = false;

                txtFt.IsEnabled = true;
                txtFt.IsVisible = true;
                lblFt.IsVisible = true;

                txtInch.IsEnabled = true;
                txtInch.IsVisible = true;
                lblInch.IsVisible = true;


            }
        }
    }
}