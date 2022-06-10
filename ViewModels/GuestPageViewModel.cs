using booking.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace booking.ViewModels
{
    class GuestPageViewModel
    {


        private void ViewRoomsFunction(object parameter)
        {
            var viewRoomsPage = new ViewRoomsPage();
            viewRoomsPage.Show();
        }

        private ICommand m_viewRooms;

        public ICommand ViewRooms
        {
            get
            {
                if (m_viewRooms == null)
                    m_viewRooms = new RelayCommand(ViewRoomsFunction);
                return m_viewRooms;
            }
        }
    }
}
