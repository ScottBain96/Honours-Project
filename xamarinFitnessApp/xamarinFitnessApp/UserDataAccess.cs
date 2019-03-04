using SQLite;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using System.Collections.ObjectModel;
namespace xamarinFitnessApp
{



    class UserDataAccess
    {



        private SQLiteConnection database;
        private static object collisionLock = new object();


        public ObservableCollection<Users> Users { get; set; }
        public UserDataAccess()
        {
            database =
              DependencyService.Get<IDatabaseConnection>().
              DbConnection();
            database.CreateTable<Users>();
            this.Users =
              new ObservableCollection<Users>(database.Table<Users>());
            // If the table is empty, initialize the collection
            if (!database.Table<Users>().Any())
            {
                AddNewCustomer();
            }
        }
        public void AddNewCustomer()
        {
            this.Users.
              Add(new Users
              {
                  UserName = "",
                  Age = "",
                  HeightCM = "",
                  WeightKG = "",
              });
        }


        public IEnumerable<Users> GetFilteredCustomers()
        {
            lock (collisionLock)
            {
                return database.Query<Users>(
                   "SELECT * FROM Item WHERE Country = 'Italy'").AsEnumerable();
            }
        }
        public Users GetCustomer(int id)
        {
            lock (collisionLock)
            {
                return database.Table<Users>().
                  FirstOrDefault(user => user.Id == id);
            }
        }

        public int SaveCustomer(Users userInstance)
        {
            lock (collisionLock)
            {
                if (userInstance.Id != 0)
                {
                    database.Update(userInstance);
                    return userInstance.Id;
                }
                else
                {
                    database.Insert(userInstance);
                    return userInstance.Id;
                }
            }
        }
        public void SaveAllCustomers()
        {
            lock (collisionLock)
            {
                foreach (var  userInstance in this.Users)
                {
                    if (userInstance.Id != 0)
                    {
                        database.Update(userInstance);
                    }
                    else
                    {
                        database.Insert(userInstance);
                    }
                }
            }
        }
        public int DeleteCustomer(Users userInstance)
        {
            var id = userInstance.Id;
            if (id != 0)
            {
                lock (collisionLock)
                {
                    database.Delete<Users>(id);
                }
            }
            this.Users.Remove(userInstance);
            return id;
        }








        public void DeleteAllCustomers()
        {
            lock (collisionLock)
            {
                database.DropTable<Users>();
                database.CreateTable<Users>();
            }
            this.Users = null;
            this.Users = new ObservableCollection<Users>
              (database.Table<Users>());
        }


    }


}

