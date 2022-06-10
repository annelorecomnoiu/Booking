using booking.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace booking.ViewModels
{
    class EmployeePageViewModel
    {

        private ICommand m_viewRooms;
        private ICommand m_viewOffers;
       
        private ICommand m_viewRezervations;

        private void ViewRoomsFunction(object parameter)
        {
            var viewRoomsPage = new ViewRoomsPage();
            viewRoomsPage.Show();
        }

        private void ViewOffersFunction(object parameter)
        {
            var viewOffersPage = new ViewOffersPage();
            viewOffersPage.Show();
        }

       
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        private void ViewRezervationsFunction(object parameter)
        {
            var viewAllRezervationsPage = new ViewAllRezervationsPage();
            viewAllRezervationsPage.Show();
        }


        public ICommand ViewRooms
        {
            get
            {
                if (m_viewRooms == null)
                    m_viewRooms = new RelayCommand(ViewRoomsFunction);
                return m_viewRooms;
            }
        }
        public ICommand ViewOffers
        {
            get
            {
                if (m_viewOffers == null)
                    m_viewOffers = new RelayCommand(ViewOffersFunction);
                return m_viewOffers;
            }
        }

        

        public ICommand ViewRezervations
        {
            get
            {
                if (m_viewRezervations == null)
                    m_viewRezervations = new RelayCommand(ViewRezervationsFunction);
                return m_viewRezervations;
            }
        }

    }
}
