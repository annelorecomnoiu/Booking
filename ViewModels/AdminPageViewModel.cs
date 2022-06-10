using booking.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace booking.ViewModels
{
    class AdminPageViewModel : INotifyPropertyChanged
    {
        private ICommand m_addFeature;
        private ICommand m_removeFeature;

        private ICommand m_addService;
        private ICommand m_removeService;
        private ICommand m_viewServices;

        private ICommand m_addRoom;
        private ICommand m_removeRoom;
        private ICommand m_updateRoom;

        private ICommand m_addPrice;
        private ICommand m_removePrice;

        private ICommand m_addOffer;
        private ICommand m_removeOffer;
        private ICommand m_viewOffers;


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        private void AddFeatureFunction(object parameter)
        {
            var newFeaturePage = new AddFeaturePage();
            newFeaturePage.Show();
        }
        private void RemoveFeatureFunction(object parameter)
        {
            var removeFeaturePage = new RemoveFeaturePage();
            removeFeaturePage.Show();
        }
        private void AddServiceFunction(object parameter)
        {
            var newServicePage = new AddServicePage();
            newServicePage.Show();
        }
        private void RemoveServiceFunction(object parameter)
        {
            var removeServicePage = new RemoveServicePage();
            removeServicePage.Show();
        }
        private void ViewServicesFunction(object parameter)
        {
            var viewServicesPage = new ViewServicesPage();
            viewServicesPage.Show();
        }
        private void AddRoomFunction(object parameter)
        {
            var addRoomPage = new AddRoomPage();
            addRoomPage.Show();
        }
        private void RemoveRoomFunction(object parameter)
        {
            var removeRoomPage = new RemoveRoomPage();
            removeRoomPage.Show();
        }
        private void UpdateRoomFunction(object parameter)
        {
            var updateRoomPage = new UpdateRoomPage();
            updateRoomPage.Show();
        }
        private void AddPriceFunction(object parameter)
        {
            var addPricePage = new AddPricePage();
            addPricePage.Show();
        }
        private void RemovePriceFunction(object parameter)
        {
            var removePricePage = new RemovePricePage();
            removePricePage.Show();
        }
        private void AddOfferFunction(object parameter)
        {
            var addOfferPage = new AddOfferPage();
            addOfferPage.Show();
        }
        private void RemoveOfferFunction(object parameter)
        {
            var removeOfferPage = new RemoveOfferPage();
            removeOfferPage.Show();
        }
        private void ViewOffersFunction(object parameter)
        {
            var viewOffersPage = new ViewOffersPage();
            viewOffersPage.Show();
        }
       

        public ICommand RemoveFeature
        {
            get
            {
                if (m_removeFeature == null)
                    m_removeFeature = new RelayCommand(RemoveFeatureFunction);
                return m_removeFeature;
            }
        }

        public ICommand AddFeature
        {
            get
            {
                if (m_addFeature == null)
                    m_addFeature = new RelayCommand(AddFeatureFunction);
                return m_addFeature;
            }
        }

        public ICommand AddService
        {
            get
            {
                if (m_addService == null)
                    m_addService = new RelayCommand(AddServiceFunction);
                return m_addService;
            }
        }
        public ICommand RemoveService
        {
            get
            {
                if (m_removeService == null)
                    m_removeService = new RelayCommand(RemoveServiceFunction);
                return m_removeService;
            }
        }

        public ICommand ViewServices
        {
            get
            {
                if (m_viewServices == null)
                    m_viewServices = new RelayCommand(ViewServicesFunction);
                return m_viewServices;
            }
        }

        public ICommand AddRoom
        {
            get
            {
                if (m_addRoom == null)
                    m_addRoom = new RelayCommand(AddRoomFunction);
                return m_addRoom;
            }
        }

        public ICommand RemoveRoom
        {
            get
            {
                if (m_removeRoom == null)
                    m_removeRoom = new RelayCommand(RemoveRoomFunction);
                return m_removeRoom;
            }
        }

        public ICommand UpdateRoom
        {
            get
            {
                if (m_updateRoom == null)
                    m_updateRoom = new RelayCommand(UpdateRoomFunction);
                return m_updateRoom;
            }
        }

        public ICommand AddPrice
        {
            get
            {
                if (m_addPrice == null)
                    m_addPrice = new RelayCommand(AddPriceFunction);
                return m_addPrice;
            }
        }
        public ICommand RemovePrice
        {
            get
            {
                if (m_removePrice == null)
                    m_removePrice = new RelayCommand(RemovePriceFunction);
                return m_removePrice;
            }
        }
        public ICommand AddOffer
        {
            get
            {
                if (m_addOffer == null)
                    m_addOffer = new RelayCommand(AddOfferFunction);
                return m_addOffer;
            }
        }
        public ICommand RemoveOffer
        {
            get
            {
                if (m_removeOffer == null)
                    m_removeOffer = new RelayCommand(RemoveOfferFunction);
                return m_removeOffer;
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
       
    }
}
