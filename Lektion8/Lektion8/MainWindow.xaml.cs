using Lektion8.Context;
using Opgave8_1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            foreach(Bil bil in context.Biler)
            {
                lbCarView.Items.Add(bil);
            }
            foreach(Ejer ejer in context.Ejere)
            {
                cbShowEJer.Items.Add(ejer);
            } 

        }

        private void cbShowEJer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lbCarView.Items.Clear();
            Ejer ej = (Ejer)cbShowEJer.SelectedItem;
            foreach(Bil bil in ej.Biler)
            {
                lbCarView.Items.Add(bil);
            }
        }
    }
}
