using booking.ViewModels;
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
using System.Windows.Shapes;

namespace booking.Views
{
    public partial class AddRezervationPage : Window
    {
        public AddRezervationPage()
        {
            
            InitializeComponent();
        }

        private void NewRezervation_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
