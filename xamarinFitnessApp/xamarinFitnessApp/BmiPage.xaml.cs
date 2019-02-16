using Microcharts;
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

        double bmi;
        double weight;
        double height;
        double test;


        List < Entry> entries = new List<Entry>
        {
            new Entry(200)
            {
                Color = SKColor.Parse("#FF1493"),
                Label = "January",
                ValueLabel = "200"
            },


             new Entry(400)
            {
                Color = SKColor.Parse("#FF1493"),
                Label = "February",
                ValueLabel = "200"
            },



              new Entry(-100)
            {
                Color = SKColor.Parse("#FF1493"),
                Label = "March",
                ValueLabel = "200"
            }
        };
		public BmiPage ()
		{

			InitializeComponent ();
            Chart1.Chart = new RadialGaugeChart { Entries = entries};
            pickerUnit.SelectedIndex = 0;

        

            //    //android
            //    string dbPath = Path.Combine(
            //Environment.GetFolderPath(Environment.SpecialFolder.Personal),
            //"database.db3");


            //    var db = new SQLiteConnection(dbPath);


        }

       // private async void Button_Clicked(object sender, EventArgs e)
       // {
       //     string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal),
       //"database.db3");
       //     var db = new SQLiteConnection(dbPath);
       //     db.CreateTable<Test>();
       //     var maxPK = db.Table<Test>().OrderByDescending(c => c.Id).FirstOrDefault();
       //     Test test = new Test();
       //     test.Name = Name.Text;
       //     test.Address = Address.Text;
       //     test.Id = (maxPK == null ? 1 : maxPK.Id + 1);
       //     //{
       //     //    Id = (maxPK == null ? 1 : maxPK.Id + 1),
       //     //    Name = Name.Text,
       //     //    Address = Address.Text
       //     //};
       //     db.Insert(test);
            
       //    // db.Close();
            
           
       // }

        private  async void  Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new profilesView());
        }



        public void convert_Metric_BMI() {

         
                weight = Double.Parse(txtWeightKg.Text.ToString());
                //Heigh is CM so divide by 100 for meters
                height = Double.Parse(txtCm.Text.ToString());
                height = height / 100;

        }


        public void convert_Imperial_BMI()
        {

            if (pickerUnit.SelectedIndex == 1)
            {

               // height = Double.parseDouble(txtHeight2.getText().toString()) * 2.54;

                //ft and inches to meters
                height = Double.Parse(txtInch.Text.ToString()) * 2.54;
                height = height + Double.Parse(txtFt.Text.ToString()) * 30.48;

                //Height to CM
                height = height / 100;

                //Lbs to Kg
                weight = Double.Parse(txtWeightLbs.Text.ToString()) / 2.20;



            }
        }

        
        public void calculateFormulaBMI()
        {
            bmi = weight / height;
            bmi = bmi / height;
            numberBMI.Text = bmi.ToString("0.00");


        }

        public void info_results_BMI()
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




            private void Button_Calculate_Clicked(object sender, EventArgs e)
        {


            try { 
            

            if (pickerUnit.SelectedIndex == 0)
            {



                convert_Metric_BMI();



            }

            else {


                convert_Imperial_BMI();

            }


            calculateFormulaBMI();
            info_results_BMI();

            }
            catch
            {
                

            }




         

        }

    

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