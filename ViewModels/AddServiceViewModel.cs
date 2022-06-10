using booking.Database;
using booking.Database.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace booking.ViewModels
{
    class AddServiceViewModel : INotifyPropertyChanged
    {
        private ICommand m_addNewService;

        private string _serviceName;
        public string ServiceName
        {
            get { return _serviceName; }
            set
            {
                _serviceName = value;
                OnPropertyChanged("ServiceName");
            }
        }

        private string _servicePrice;
        public string ServicePrice
        {
            get { return _servicePrice; }
            set
            {
                _servicePrice = value;
                OnPropertyChanged("ServicePrice");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        private async void AddNewServiceFunction(object parameter)
        {
            using (var dbContext = new BookingContext())
            {
                ServiciuRepository serviciuRepository = new ServiciuRepository(dbContext);
                if (serviciuRepository.AddServiciu(ServiceName, float.Parse(ServicePrice)) == true)
                {
                    UnitOfWork unitOfWork = new UnitOfWork(dbContext);
                    await unitOfWork.SaveChangesAsync();
                    MessageBox.Show("Serviciul s-a adaugat cu succes!");
                    return;
                }
                MessageBox.Show("Adaugarea nu s-a putut efectua, verificati ca aceasta sa nu existe deja in baza de date");
            }
        }

        public ICommand AddNewService
        {
            get
            {
                if (m_addNewService == null)
                    m_addNewService = new RelayCommand(AddNewServiceFunction);
                return m_addNewService;
            }
        }
    }
}
