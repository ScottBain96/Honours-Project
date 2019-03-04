using SQLite;
using System.ComponentModel;
namespace xamarinFitnessApp
{
    [Table("User")]
    public class Users : INotifyPropertyChanged
    {
        private int _id;
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                this._id = value;
                OnPropertyChanged(nameof(Id));
            }
        }
        private string _userName;
        //[NotNull]
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                this._userName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        private string _age;

        public string Age
        {
            get
            {
                return _age;
            }
            set
            {
                this._age = value;
                OnPropertyChanged(nameof(Age));
            }
        }




        private string _heightCM;
        public string HeightCM
        {
            get
            {
                return _heightCM;
            }
            set
            {
                this._heightCM = value;
                OnPropertyChanged(nameof(HeightCM));
            }
        }
        private string _weightKG;
        public string WeightKG
        {
            get
            {
                return _weightKG;
            }
            set
            {
                _weightKG = value;
                OnPropertyChanged(nameof(WeightKG));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this,
              new PropertyChangedEventArgs(propertyName));
        }
    }
}