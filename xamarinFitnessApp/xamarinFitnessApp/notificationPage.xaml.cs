using Plugin.LocalNotifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarinFitnessApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class notificationPage : ContentPage
    {


   
        
        public notificationPage()
        {
            InitializeComponent();

          






        }



      



        private void Button_Clicked(object sender, EventArgs e)
            {

            //Calculate hours between current Date and time and selected Date, EXACT HOURS not 24 per day, converted to minutes.
            var hours = (datePicker.Date - DateTime.Today).TotalHours * 60;
            var myTime = DateTime.Now.ToShortTimeString();
            string replace = myTime.ToString();
            replace = replace.Replace(':', '.');
            //Splitting hours and minutes
            string[] parts = replace.Split('.');
            int i1 = int.Parse(parts[0]);
            int i2 = int.Parse(parts[1]);

            int minutes = (i1 * 60) + i2;



            double todaysHours = Convert.ToDouble(minutes);

            //substract the total hours of the days difference and the current hour of the day to get the exact hours till selected date.
            double dayDifferenceHours = hours - todaysHours;

            //            txtToDo.Text = totalHours.ToString();



            //PICKER HOURS

            string pickerValue = timePicker.Time.ToString();
          
            //int pos = 1 + pickerValue.IndexOf(':');
            //pickerValue = pickerValue.Substring(0, pos) + pickerValue.Substring(pos).Replace(":", string.Empty);
            //pickerValue = pickerValue.Replace(':', '.');
            
           
            //convert pickerHours to minutes
            //Splitting hours and minutes

            string[] parts2 = pickerValue.Split(':');
            int i3 = int.Parse(parts2[0]);
            int i4 = int.Parse(parts2[1]);
            //txtToDo.Text = pickerValue;
            //txtdayDiff.Text = i3.ToString();
            //txtTimeDiff.Text = i4.ToString();
            int minutes2 = (i3 * 60) + i4;
           
            double pickerHours = Convert.ToDouble(minutes2);
            double totalhours = dayDifferenceHours + pickerHours;
            txtdayDiff.Text = dayDifferenceHours.ToString();
            txtTimeDiff.Text = pickerHours.ToString();
            txtToDo.Text = totalhours.ToString();





            string myNotification = "this is a test";
            CrossLocalNotifications.Current.Show("Your reminder:", myNotification, 101, DateTime.Now.AddMinutes(totalhours));
        }
        }
}