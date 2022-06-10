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
    class RemovePriceViewModel : INotifyPropertyChanged
    {
        private ICommand m_removePrice;

        private string _selectedPret;
        public string SelectedPret
        {
            get { return _selectedPret; }
            set
            {
                _selectedPret = value;
                using (var dbContext = new BookingContext())
                {
                    PretRepository pretRepository = new PretRepository(dbContext);
                    CameraRepository cameraRepository = new CameraRepository(dbContext);
                    Pret currentPret = pretRepository.GetById(Int32.Parse(_selectedPret));
                    PriceValue = currentPret.Valoare.ToString();
                    DateStart = currentPret.DataStart.ToString();
                    DateEnd = currentPret.DataEnd.ToString();
                    Camera cameraOfPrice = cameraRepository.GetById(currentPret.IdCamera);
                    RoomName = cameraOfPrice.Nume;
                }
                OnPropertyChanged("SelectedPret");
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
        private string _roomName;
        public string RoomName
        {
            get { return _roomName; }
            set
            {
                _roomName = value;
                OnPropertyChanged("RoomName");
            }
        }
        private string _dateStart;
        public string DateStart
        {
            get { return _dateStart; }
            set
            {
                _dateStart = value;
                OnPropertyChanged("DateStart");
            }
        }
        private string _dateEnd;
        public string DateEnd
        {
            get { return _dateEnd; }
            set
            {
                _dateEnd = value;
                OnPropertyChanged("DateEnd");
            }
        }
        public ObservableCollection<string> Preturi { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        private async void RemovePriceFunction(object parameter)
        {
            using (var dbContext = new BookingContext())
            {
                PretRepository pretRepository = new PretRepository(dbContext);
                if (pretRepository.DeletePret(SelectedPret) == true)
                {
                    UnitOfWork unitOfWork = new UnitOfWork(dbContext);
                    await unitOfWork.SaveChangesAsync();
                    MessageBox.Show("Pretul s-a sters cu succes!");
                    return;
                }
                MessageBox.Show("Stergerea nu s-a putut efectua!");
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

        public RemovePriceViewModel()
        {
            using (var dbContext = new BookingContext())
            {
                PretRepository pretRepository = new PretRepository(dbContext);
                Preturi = new ObservableCollection<string>(from pret in pretRepository.GetAll() where pret.DeletedAt == false select pret.Id.ToString());
            }
        }
    }
}
