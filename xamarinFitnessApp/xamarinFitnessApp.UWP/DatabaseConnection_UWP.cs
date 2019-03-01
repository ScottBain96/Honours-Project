using SQLite;
using Xamarin.Forms;
using xamarinFitnessApp.UWP;
using Windows.Storage;
using System.IO;
[assembly: Dependency(typeof(DatabaseConnection_UWP))]
namespace xamarinFitnessApp.UWP
{
    public class DatabaseConnection_UWP : IDatabaseConnection
    {
        public SQLiteConnection DbConnection()
        {
            var dbName = "CustomersDb.db3";
            var path = Path.Combine(ApplicationData.
              Current.LocalFolder.Path, dbName);
            return new SQLiteConnection(path);
        }
    }
}