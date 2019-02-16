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
	public partial class ToolsPage : ContentPage
	{
		public ToolsPage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked_BMI(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BmiPage());
        }

        private void Button_Clicked_profile(object sender, EventArgs e)
        {
            Navigation.PushAsync(new profilesView());
            //changeback to profile page
        }

        private void Button_Clicked_Cals(object sender, EventArgs e)
        {
           
        }
    }
}