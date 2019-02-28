using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcharts;
using SkiaSharp;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Entry = Microcharts.Entry;

namespace xamarinFitnessApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class myProfile : ContentPage
    {
        public myProfile()
        {
            InitializeComponent();

           
        }

        private void Button_Clicked_GraphDisplay(object sender, EventArgs e)
        {

            string timeOfNow = DateTime.Now.ToString();

            int weight;
            int weight2;
            weight2 = 4;
            weight = Int32.Parse(txtWeight.Text.ToString());
            List<Entry> entries = new List<Entry>
        {
            new Entry(weight)
            {
                Color = SKColor.Parse("#a256ff"),
                Label = timeOfNow,
                ValueLabel = weight.ToString()
            },


             new Entry(weight2)
            {
                Color = SKColor.Parse("#f44141"),
                Label = timeOfNow,
                ValueLabel = weight2.ToString()
            }



        };


            Chart2.Chart = new LineChart { Entries = entries };
        }
    }
}