﻿using System;
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

namespace Opgave6_2
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Label lbl = new Label();
            lbl.Content = lbl1.Content;
            lbl1.Content = lbl2.Content;
            lbl2.Content = lbl.Content;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Label lbl = new Label();
            lbl.Content = lbl3.Content;
            lbl3.Content = lbl4.Content;
            lbl4.Content = lbl.Content;

        }
    }
}
