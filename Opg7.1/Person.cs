using System.ComponentModel;

namespace Opg7._1
{
    internal class Person : INotifyPropertyChanged
    {
        private string _name;
        private int _age;
        private bool _accepted;

        public event PropertyChangedEventHandler PropertyChanged;

        public Person(string name, int age, bool accepted)
        {
            _name = name;
            _age = age;
            _accepted = accepted;
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }


        public int Age
        {
            get => _age;
            set
            {
                _age = value;
                OnPropertyChanged("Age");
            }
        }
        public bool Accepted
        {
            get => _accepted;
            set
            {
                _accepted = value;
                OnPropertyChanged("Accepted");
            }
        }
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Accepted: {Accepted}";
        }

        public string ListboxToString()
        {
            return $"{Name} - {Age} - {Accepted}";
        }

    }
}
