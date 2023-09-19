using System.ComponentModel;

namespace Opg7._1
{
    public class Person : INotifyPropertyChanged
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

        public override string ToString()
        {
            return $"{Name} {Age} {Accepted}";
        }

        public string listboxToString
        {
            get => $"{Name} {Age} {Accepted}";
        }


        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
