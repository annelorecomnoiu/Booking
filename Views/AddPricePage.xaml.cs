﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace booking.Views
{
    /// <summary>
    /// Interaction logic for AddPricePage.xaml
    /// </summary>
    public partial class AddPricePage : Window
    {
        public AddPricePage()
        {
            InitializeComponent();
        }

        private void AddPrice_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
