using Plugin.LocalNotifications;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace xamarinFitnessApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Handle when your app starts
            if (Application.Current.Properties.ContainsKey("FirstUse"))
            {
                //Do things when it's NOT the first use...
                MainPage = new NavigationPage(new MainMenu());
            }
            else
            {
                Application.Current.Properties["FirstUse"] = false;
                //Do things when it IS the first use...
                MainPage = new NavigationPage(new MainPage());

            }

        }

        protected override void OnStart()
        {

            CrossLocalNotifications.Current.Show("Worked out today?", "Try one of the workouts! Everything counts!", 2000000, DateTime.Now.AddMinutes(180));

        }

     

        protected override void OnSleep() 
        {
            // Handle when your app sleeps
            CrossLocalNotifications.Current.Show("Been active today?", "Make sure to be active to achieve your goals!", 20000000, DateTime.Now.AddDays(1));
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            CrossLocalNotifications.Current.Show("Still on target?", "Make sure to check your daily calorie intake", 2000000000, DateTime.Now.AddMinutes(60));
        }
    }
}
