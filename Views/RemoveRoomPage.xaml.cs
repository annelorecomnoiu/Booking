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
    /// Interaction logic for RemoveRoomPage.xaml
    /// </summary>
    public partial class RemoveRoomPage : Window
    {
        public RemoveRoomPage()
        {
            InitializeComponent();
        }

        private void RemoveRoom_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
