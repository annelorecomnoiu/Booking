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
    class AddPriceViewModel : INotifyPropertyChanged
    {
        private ICommand m_addNewPrice;

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
        public ObservableCollection<string> Camere { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        private async void AddNewPriceFunction(object parameter)
        {
            using (var dbContext = new BookingContext())
            {
                PretRepository pretRepository = new PretRepository(dbContext);
                CameraRepository cameraRepository = new CameraRepository(dbContext);

                List<Camera> camereDB = cameraRepository.GetAll().ToList();
                Camera cameraAdaugata = camereDB.Find(c => c.Nume.Equals(SelectedCamera));


                await pretRepository.AddPretAsync(cameraAdaugata, StartDate, EndDate, float.Parse(PriceValue));
                MessageBox.Show("Pretul a fost adaugat cu succes");
            }
        }

        public ICommand AddNewPrice
        {
            get
            {
                if (m_addNewPrice == null)
                    m_addNewPrice = new RelayCommand(AddNewPriceFunction);
                return m_addNewPrice;
            }
        }

        public AddPriceViewModel()
        {
            using (var dbContext = new BookingContext())
            {
                CameraRepository cameraRepository = new CameraRepository(dbContext);
                Camere = new ObservableCollection<string>(from camera in cameraRepository.GetAll() where camera.DeletedAt == false select camera.Nume);
            }
        }
    }
}
