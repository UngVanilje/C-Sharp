using Lektion8.Context;
using Opgave8_1;
using Opgave8_1.Model;
using System.Windows;
using System.Windows.Controls;

namespace Lektion8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BilContext context = new BilContext();
        public MainWindow()
        {
            InitializeComponent();
            bool created = context.Database.EnsureCreated();
            if (created)
            {
                MessageBox.Show("Database created");
            }
            foreach (Bil bil in context.Biler)
            {
                lbCarView.Items.Add(bil);
            }
            foreach (Ejer ejer in context.Ejere)
            {
                cbShowEJer.Items.Add(ejer);
            }

        }

        private void cbShowEJer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lbCarView.Items.Clear();
            Ejer ej = (Ejer)cbShowEJer.SelectedItem;
            foreach (Bil bil in ej.Biler)
            {
                lbCarView.Items.Add(bil);
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            EditCarWindow editCar = new EditCarWindow();
            editCar.Show();
            RefreshData();
        }

        private void RefreshData()
        {
            lbCarView.Items.Clear();
            cbShowEJer.Items.Clear();

            foreach (Bil bil in context.Biler)
            {
                lbCarView.Items.Add(bil);
            }
            foreach (Ejer ejer in context.Ejere)
            {
                cbShowEJer.Items.Add(ejer);
            }
        }
    }
}

