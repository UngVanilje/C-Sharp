using Opg7._1;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Opg7._4
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<Person> people;
        public MainWindow()
        {
            InitializeComponent();
            IntializeData();


        }

        private void IntializeData()
        {
            people = new ObservableCollection<Person>()
              {
                new Person("Krølle", 34, true),
                new Person("Bokki", 28, true),
                new Person("Gewir", 25, true),
                new Person("Bølle", 18, false),
                new Person("Bigman", 45, false),
                new Person("Bøf", 34, true),
                new Person("Sui", 44, false),
                new Person("Susanne", 34, true),
                new Person("Konrad", 14, false),
                new Person("Kurt", 34, true),
                new Person("Kaj", 33, true),
                new Person("Karl", 12, false),
                new Person("Michael", 21, false),

            };

            listBox.ItemsSource = people;
            mainGrid.DataContext = people;
        }



        private void Tilføj_person_Click(object sender, RoutedEventArgs e)
        {

            string name = tb1.Text;
            int age = int.Parse(tb2.Text);
            bool accepted = cb1.IsChecked ?? false;
            people.Add(new Person(name, age, accepted));
            ClearInputFields();
        }

        private void Ret_person_Click(object sender, RoutedEventArgs e)
        {

            if (listBox.SelectedItem is Person selectedPerson)
            {
                EditPerson editPerson = new EditPerson(selectedPerson);
                editPerson.Closed += Window_Closed;
                editPerson.ShowDialog();
            }
        }
        private void Window_Closed(object sender, System.EventArgs e)
        {
            var p = listBox.SelectedItem as Person;
            listBox.Items.Refresh();
            UpdateSelectedPersonFields();
            ClearInputFields();
        }

        private void UpdateSelectedPersonFields()
        {
            if (listBox.SelectedItem is Person selectedPerson)
            {
                tb1.Text = selectedPerson.Name;
                tb2.Text = selectedPerson.Age.ToString();
                cb1.IsChecked = selectedPerson.Accepted;
            }
        }
        private void ClearInputFields()
        {
            tb1.Clear();
            tb2.Clear();
            cb1.IsChecked = false;
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateSelectedPersonFields();
        }

        private void cb1_Checked(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedItem is Person selectedPerson)
            {
                selectedPerson.Accepted = (bool)cb1.IsChecked;
                listBox.Items.Refresh();
            }
        }

        private void cb1_Unchecked(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedItem is Person selectedPerson)
            {
                selectedPerson.Accepted = (bool)cb1.IsChecked;
                listBox.Items.Refresh();
            }
        }
    }
}
