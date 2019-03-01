using xamarinFitnessApp.iOS;
using SQLite;
using System;
using System.IO;
[assembly: Xamarin.Forms.Dependency(typeof(DatabaseConnection_iOS))]
namespace xamarinFitnessApp.iOS
{
    public class DatabaseConnection_iOS
    {
        public SQLiteConnection DbConnection()
        {
            var dbName = "CustomersDb.db3";
            string personalFolder =
              System.Environment.
              GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryFolder =
              Path.Combine(personalFolder, "..", "Library");
            var path = Path.Combine(libraryFolder, dbName);
            return new SQLiteConnection(path);
        }
    }
}