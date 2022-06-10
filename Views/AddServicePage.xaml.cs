using System;
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
    /// Interaction logic for AddServicePage.xaml
    /// </summary>
    public partial class AddServicePage : Window
    {
        public AddServicePage()
        {
            InitializeComponent();
        }

        private void AddService_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string result = "";
            char[] validChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ',', '.' }; // these are ok
            foreach (char c in TextBox1.Text) // check each character in the user's input
            {
                if (Array.IndexOf(validChars, c) != -1)
                    result += c; // if this is ok, then add it to the result
            }

            TextBox1.Text = result; // change the text to the "clean" version where illegal chars have been removed.
        }
    }
}
