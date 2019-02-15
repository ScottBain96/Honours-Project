using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarinFitnessApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class profilesView : ContentPage
	{

        private ListView _listView;


        string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal),
  "database.db3");

        public profilesView ()
		{

            var db = new SQLiteConnection(dbPath);


            StackLayout stackLayout = new StackLayout();
            _listView = new ListView();

            _listView.ItemsSource = db.Table<Test>().OrderBy(x => x.Name).ToList();

            stackLayout.Children.Add(_listView);

            Content = stackLayout;

            //    var db = new SQLiteConnection(dbPath);

           

        }
    }
}