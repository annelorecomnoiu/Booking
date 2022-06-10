using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
    /// Interaction logic for UpdateRoomPage.xaml
    /// </summary>
    public partial class UpdateRoomPage : Window
    {
        public UpdateRoomPage()
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
