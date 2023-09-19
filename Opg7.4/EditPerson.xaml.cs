using Opg7._1;
using System.Windows;

namespace Opg7._4
{
    public partial class EditPerson : Window
    {
        private Person person;

        public EditPerson(Person p)
        {
            InitializeComponent();
            person = p;
            LoadPersonData();
        }

        private void LoadPersonData()
        {
            DataContext = person;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            Close();
        }

        private void btnAnnuller_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
