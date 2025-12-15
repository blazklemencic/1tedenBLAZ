using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ZaposleniPlace
{
    class Zaposlen : INotifyPropertyChanged
    {
        private int id;
        private string name;
        private int age;
        private double salary;

        public int ID
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged(nameof(ID));
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                OnPropertyChanged(nameof(Age));
            }
        }
        public double Salary
        {
            get { return salary; }
            set
            {
                salary = value;
                OnPropertyChanged(nameof(Salary));
            }
        }

        public Zaposlen(int id,  string name, int age, double salary)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
