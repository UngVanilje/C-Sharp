using System.Windows;

namespace Opg7._1
{/// <summary>
 /// Interaction logic for MainWindow.xaml
 /// </summary>
    public partial class MainWindow : Window
    {
        private Person person = new Person("Ole", 13, true);
        public MainWindow()
        {
            InitializeComponent();
            main.DataContext = person;
        }

        private void Ret_person_Click(object sender, RoutedEventArgs e)
        {
            person.Name = "Kim";
            person.Accepted = false;
        }

        private void Udskift_person_Click(object sender, RoutedEventArgs e)
        {
            person = new Person("Ib", 67, true);
            main.DataContext = person;
        }

        private void Vis_person_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Navn:" + person.Name + ", Alder:" + person.Age + ", Accepted:" + person.Accepted);
        }
    }
}