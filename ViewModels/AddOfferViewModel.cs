using booking.Database;
using booking.Database.Models;
using booking.Database.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace booking.ViewModels
{
    class AddOfferViewModel : INotifyPropertyChanged
    {
        private ICommand m_addService;
        private ICommand m_removeService;
        private ICommand m_addOffer;

        private string _offerName;
        public string OfferName
        {
            get { return _offerName; }
            set
            {
                _offerName = value;
                OnPropertyChanged("OfferName");
            }
        }

        private string _priceValue;
        public string PriceValue
        {
            get { return _priceValue; }
            set
            {
                _priceValue = value;
                OnPropertyChanged("PriceValue");
            }
        }

        private DateTime _startDate = DateTime.Now;
        public DateTime StartDate
        {
            get { return _startDate; }
            set
            {
                _startDate = value;
                OnPropertyChanged("StartDate");
            }
        }

        private DateTime _endDate = DateTime.Now;
        public DateTime EndDate
        {
            get { return _endDate; }
            set
            {
                _endDate = value;
                OnPropertyChanged("EndDate");
            }
        }

        private string _selectedCamera;
        public string SelectedCamera
        {
            get { return _selectedCamera; }
            set
            {
                _selectedCamera = value;
                OnPropertyChanged("SelectedCamera");
            }
        }

        private string _currentNewService;
        public string CurrentNewService
        {
            get { return _currentNewService; }
            set
            {
                _currentNewService = value;
                OnPropertyChanged("CurrentNewService");
            }
        }

        private string _currentAddedService;
        public string CurrentAddedService
        {
            get { return _currentAddedService; }
            set
            {
                _currentAddedService = value;
                OnPropertyChanged("CurrentAddedService");
            }
        }

        public ObservableCollection<string> ServiciiOferta { get; set; }
        public ObservableCollection<string> ServiciiAdaugate { get; set; }
        public ObservableCollection<string> Camere { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        private void AddServiceFunction(object parameter)
        {
            ServiciiAdaugate.Add(CurrentNewService);
            ServiciiOferta.Remove(CurrentNewService);
        }
        private void RemoveServiceFunction(object parameter)
        {
            ServiciiOferta.Add(CurrentAddedService);
            ServiciiAdaugate.Remove(CurrentAddedService);
        }
        private async void AddOfferFunction(object parameter)
        {
            using (var dbContext = new BookingContext())
            {
                CameraRepository cameraRepository = new CameraRepository(dbContext);
                List<Camera> camereDB = cameraRepository.GetAll().ToList();
                Camera cameraAdaugata = camereDB.Find(c => c.Nume.Equals(SelectedCamera));

                OfertaRepository ofertaRepository = new OfertaRepository(dbContext);
                await ofertaRepository.AddOferta(OfferName, float.Parse(PriceValue), cameraAdaugata, StartDate, EndDate);
            }

            using (var dbContext = new BookingContext())
            {
                OfertaRepository ofertaRepository = new OfertaRepository(dbContext);
                ServiciuRepository serviciuRepository = new ServiciuRepository(dbContext);
                ServiciiOfertaRepository serviciiOfertaRepository = new ServiciiOfertaRepository(dbContext);

                List<Serviciu> serviciiDB = serviciuRepository.GetAll().ToList();
                List<Serviciu> serviciiDeAdaugatInDB = new List<Serviciu>();
                foreach (var serviciu in serviciiDB)
                {
                    if (ServiciiAdaugate.Contains(serviciu.Nume))
                        serviciiDeAdaugatInDB.Add(serviciu);
                }
                List<Oferta> ofertaDB = ofertaRepository.GetAll().ToList();
                Oferta ofertaAdaugata = ofertaDB.Find(c => c.Nume.Equals(OfferName));

                serviciiOfertaRepository.AddServicii(serviciiDeAdaugatInDB, ofertaAdaugata);
                UnitOfWork unitOfWork = new UnitOfWork(dbContext);
                await unitOfWork.SaveChangesAsync();
            }
            MessageBox.Show("Oferta a fost adaugata cu succes");
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
        public ICommand AddService
        {
            get
            {
                if (m_addService == null)
                    m_addService = new RelayCommand(AddServiceFunction);
                return m_addService;
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

        public AddOfferViewModel()
        {
            using (var dbContext = new BookingContext())
            {
                ServiciuRepository serviciuRepository = new ServiciuRepository(dbContext);
                ServiciiOferta = new ObservableCollection<string>(from serviciu in serviciuRepository.GetAll() where serviciu.DeletedAt == false select serviciu.Nume);
                CameraRepository cameraRepository = new CameraRepository(dbContext);
                Camere = new ObservableCollection<string>(from camera in cameraRepository.GetAll() where camera.DeletedAt == false select camera.Nume);
            }
            ServiciiAdaugate = new ObservableCollection<string>();
        }
    }
}
