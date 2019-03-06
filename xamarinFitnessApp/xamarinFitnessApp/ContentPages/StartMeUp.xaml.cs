using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarinFitnessApp.ContentPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StartMeUp : ContentPage
	{
		public StartMeUp ()
		{
			InitializeComponent ();


         


         
        }

        private void Button_Clicked_Exit(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}