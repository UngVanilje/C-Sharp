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

namespace _6._6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnbuttom_Click(object sender, RoutedEventArgs e)
        {
            btncenter.Content += "\nButtom was here";
        }

        private void btncenter_Click(object sender, RoutedEventArgs e)
        {
            btncenter.Content = "Center";
        }

        private void btntop_Click(object sender, RoutedEventArgs e)
        {
            btncenter.Content += "\nTop was here";
        }

        private void btnright_Click(object sender, RoutedEventArgs e)
        {
            btncenter.Content += "\nRight was here";
        }

        private void btnleft_Click(object sender, RoutedEventArgs e)
        {
            btncenter.Content += "\nLeft was here";
        }
    }
}
