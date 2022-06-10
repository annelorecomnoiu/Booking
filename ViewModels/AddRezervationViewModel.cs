using booking.Database;
using booking.Database.Models;
using booking.Database.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace booking.ViewModels
{
    class AddRezervationViewModel : INotifyPropertyChanged
    {
        
        
        private ICommand m_addService;
        private ICommand m_removeService;
        private ICommand m_addRezervation;


        private int _idRezervare;
        public int IdRezervare
        {
            get { return _idRezervare; }
            set
            {
                _idRezervare = value;
                OnPropertyChanged("IdRezervare");
            }
        }

        private string _cameraName;
        public string CameraName
        {
            get { return _cameraName; }
            set
            {
                _cameraName = value;
                OnPropertyChanged("CameraName");
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

        private int _nrCamere;
        public int NrCamere
        {
            get { return _nrCamere; }
            set
            {
                _nrCamere = value;
                OnPropertyChanged("NrCamere");
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

        private string _selectedOffer;
        public string SelectedOffer
        {
            get { return _selectedOffer; }
            set
            {
                _selectedOffer = value;
                OnPropertyChanged("SelectedOffer");
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

        

        public ObservableCollection<string> Rezervare { get; set; }
        public ObservableCollection<string> ServiciiRezervare { get; set; }
        public ObservableCollection<string> ServiciiAdaugate { get; set; }
        public ObservableCollection<string> Camere { get; set; }
        public ObservableCollection<string> Oferte { get; set; }

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
            ServiciiRezervare.Remove(CurrentNewService);
        }
        private void RemoveServiceFunction(object parameter)
        {
            ServiciiRezervare.Add(CurrentAddedService);
            ServiciiAdaugate.Remove(CurrentAddedService);
        }
        public async void AddRezervationFunction(string username)
        {
            using (var dbContext = new BookingContext())
            {
                CameraRepository cameraRepository = new CameraRepository(dbContext);
                List<Camera> camereDB = cameraRepository.GetAll().ToList();
                Camera cameraAdaugata = camereDB.Find(c => c.Nume.Equals(SelectedCamera));

                OfertaRepository offerRepository = new OfertaRepository(dbContext);
                List<Oferta> oferteDB = offerRepository.GetAll().ToList();
                Oferta ofertaAdaugata = oferteDB.Find(c => c.Nume.Equals(SelectedOffer));

                UserRepository userRepository = new UserRepository(dbContext);
                List<User> useriDB = userRepository.GetAll().ToList();
                User current_user = useriDB.Find(c => c.Username.Equals(username));

                RezervareRepository rezervationRepository = new RezervareRepository(dbContext);
                await rezervationRepository.AddRezervare(current_user.Id, cameraAdaugata.Id, ofertaAdaugata.Id, NrCamere, StartDate, EndDate);
           
                RezervareRepository rezervareRepository = new RezervareRepository(dbContext);
                OfertaRepository ofertaRepository = new OfertaRepository(dbContext);
                ServiciuRepository serviciuRepository = new ServiciuRepository(dbContext);
                ServiciiRezervareRepository serviciiRezervareRepository = new ServiciiRezervareRepository(dbContext);

                List<Serviciu> serviciiDB = serviciuRepository.GetAll().ToList();
                List<Serviciu> serviciiDeAdaugatInDB = new List<Serviciu>();
                foreach (var serviciu in serviciiDB)
                {
                    if (ServiciiAdaugate.Contains(serviciu.Nume))
                        serviciiDeAdaugatInDB.Add(serviciu);
                }
                List<Rezervare> rezervareDB = rezervareRepository.GetAll().ToList();
                Rezervare rezervareAdaugata =rezervareDB.Find(c => c.Id.Equals(IdRezervare));

                serviciiRezervareRepository.AddServicii(serviciiDeAdaugatInDB, rezervareAdaugata);
                UnitOfWork unitOfWork = new UnitOfWork(dbContext);
                await unitOfWork.SaveChangesAsync();
            }
            MessageBox.Show("Rezervarea a fost adaugata cu succes");
        }

        public async void AddRezervationFunction(object parameter)
        {

            User currentUser;
            Camera camera_adaugata;

            using (var dbContext = new BookingContext())
            {
                CameraRepository cameraRepository = new CameraRepository(dbContext);
                List<Camera> camereDB = cameraRepository.GetAll().ToList();
                Camera cameraAdaugata = camereDB.Find(c => c.Nume.Equals(SelectedCamera));
                camera_adaugata = cameraAdaugata;

                OfertaRepository offerRepository = new OfertaRepository(dbContext);
                List<Oferta> oferteDB = offerRepository.GetAll().ToList();
                Oferta ofertaAdaugata = oferteDB.Find(c => c.Nume.Equals(SelectedOffer));

                UserRepository userRepository = new UserRepository(dbContext);
                List<User> useriDB = userRepository.GetAll().ToList();
                User current_user = useriDB.Find(c => c.Username.Equals("client"));
                currentUser = current_user;

                RezervareRepository rezervationRepository = new RezervareRepository(dbContext);
                await rezervationRepository.AddRezervare(current_user.Id, cameraAdaugata.Id, ofertaAdaugata.Id, NrCamere, StartDate, EndDate);
            }
                using (var dbContext = new BookingContext())
                {
                RezervareRepository rezervareRepository = new RezervareRepository(dbContext);
                OfertaRepository ofertaRepository = new OfertaRepository(dbContext);
                ServiciuRepository serviciuRepository = new ServiciuRepository(dbContext);
                ServiciiRezervareRepository serviciiRezervareRepository = new ServiciiRezervareRepository(dbContext);

                List<Serviciu> serviciiDB = serviciuRepository.GetAll().ToList();
                List<Serviciu> serviciiDeAdaugatInDB = new List<Serviciu>();
                foreach (var serviciu in serviciiDB)
                {
                    if (ServiciiAdaugate.Contains(serviciu.Nume))
                        serviciiDeAdaugatInDB.Add(serviciu);
                }
             
                //List<Rezervare> rezervareDB = rezervareRepository.GetAll().ToList();
                
                //Rezervare rezervareAdaugata = rezervareDB.Find(c =>c.IdUser.Equals(currentUser.Id) && c.IdCamera.Equals(camera_adaugata.Id));

                //serviciiRezervareRepository.AddServicii(serviciiDeAdaugatInDB, rezervareAdaugata);
                //UnitOfWork unitOfWork = new UnitOfWork(dbContext);
                //await unitOfWork.SaveChangesAsync();
            }
            MessageBox.Show("Rezervarea a fost adaugata cu succes");
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

        public ICommand AddRezervation
        {
            get
            {
                if (m_addRezervation == null)
                    m_addRezervation = new RelayCommand(AddRezervationFunction);
                return m_addRezervation;
            }
        }

        public AddRezervationViewModel()
        {
            using (var dbContext = new BookingContext())
            {
                ServiciuRepository serviciuRepository = new ServiciuRepository(dbContext);
                ServiciiRezervare = new ObservableCollection<string>(from serviciu in serviciuRepository.GetAll() where serviciu.DeletedAt == false select serviciu.Nume);
                
                CameraRepository cameraRepository = new CameraRepository(dbContext);
                Camere = new ObservableCollection<string>(from camera in cameraRepository.GetAll() where camera.DeletedAt == false select camera.Nume);
                
                OfertaRepository ofertaRepository = new OfertaRepository(dbContext);
                Oferte = new ObservableCollection<string>(from oferta in ofertaRepository.GetAll() where oferta.DeletedAt == false select oferta.Nume);
            }
            ServiciiAdaugate = new ObservableCollection<string>();
        }
    }
}

