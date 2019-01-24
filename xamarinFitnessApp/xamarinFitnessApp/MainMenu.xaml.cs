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
	public partial class MainMenu : ContentPage
	{
		public MainMenu ()
		{
			InitializeComponent ();
		}



        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            //myLabel.Text = "Changed";
            Navigation.PushAsync(new MainPage());
        }

        private void ImageButton_Clicked_Tools(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ToolsPage());
        }


    }
}