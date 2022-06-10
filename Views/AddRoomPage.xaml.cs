using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for AddRoomPage.xaml
    /// </summary>
    public partial class AddRoomPage : Window
    {
        public AddRoomPage()
        {
            InitializeComponent();
        }

        private void NrCamere_TextChanged(object sender, TextChangedEventArgs e)
        {
            Regex regex = new Regex("^[0-9]{0,2}$");
            if (!regex.IsMatch(NumarCamere.Text))
            {
                NumarCamere.Text = NumarCamere.Text.Substring(0, 2);
                NumarCamere.Select(2, 0);
            }

        }
    }
}
