using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace testXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            
        }

       
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TestPage());
            myLabel.Text = myEntry.Text;             
        }
    }
}
