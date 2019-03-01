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
            //txtTest.Text = this.dataAccess.GetCustomer(2).CompanyName;
        }

    

        // An event that is raised when the page is shown
        protected override void OnAppearing()
        {
            base.OnAppearing();
            // The instance of CustomersDataAccess
            // is the data binding source
            this.BindingContext = this.dataAccess;
        }

        // Save any pending changes
        private void OnSaveClick(object sender, EventArgs e)
        {
            this.dataAccess.SaveAllCustomers();
        }
        // Add a new customer to the Customers collection
        private void OnAddClick(object sender, EventArgs e)
        {
            this.dataAccess.AddNewCustomer();
        }
        // Remove the current customer
        // If it exist in the database, it will be removed
        // from there too
        private void OnRemoveClick(object sender, EventArgs e)
        {
            var currentCustomer =
              this.UsersView.SelectedItem as Users;
            if (currentCustomer != null)
            {
                this.dataAccess.DeleteCustomer(currentCustomer);
            }
        }
        // Remove all customers
        // Use a DisplayAlert object to ask the user's confirmation
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
                    this.BindingContext = this.dataAccess;
                }
            }
        }

        private void BtnView_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new BmiPage());

            //txtView.Text = this.dataAccess.GetCustomer(1).CompanyName;


        }
    }
}