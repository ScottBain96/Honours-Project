using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testXamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TestPage : ContentPage
	{
		public TestPage ()
		{
			InitializeComponent ();
		}

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            myLabel.Text = "Changed";
        }
    }
}