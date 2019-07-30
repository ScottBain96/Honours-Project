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
    public partial class Profile : ContentPage
    {
        private UserDataAccess dataAccess;

        public Profile()
        {
            InitializeComponent();
            this.dataAccess = new UserDataAccess();
            
        }

    

        // An event that is raised when the page is shown
        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.BindingContext = this.dataAccess;
        }

      
        private void OnSaveClick(object sender, EventArgs e)
        {
            this.dataAccess.SaveAllCustomers();
      
        }
    
        private void OnAddClick(object sender, EventArgs e)
        {
        
            this.dataAccess.AddNewCustomer();
        }
    

        // Remove all
        private async void OnRemoveAllClick(object sender, EventArgs e)
        {
            if (this.dataAccess.Users.Any())
            {
                var result =
                  await DisplayAlert("Confirmation",
                  "Are you sure? This cannot be undone",
                  "OK", "Cancel");
                if (result == true)
                {
                    this.dataAccess.DeleteAllCustomers();
                    OnAppearing();
                }
            }
        }

        private void BtnView_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new BmiPage());

          

        }

        private void Help_Activated(object sender, EventArgs e)
        {
            DisplayAlert("Help info", "Create a Profile that can be used for inputting data fast into other calculators!", "Ok");
        }
    }
}