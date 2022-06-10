using booking.Database;
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
    class RemoveServiceViewModel : INotifyPropertyChanged
    {
        private ICommand m_removeService;

        private string _selectedServiciu;
        public string SelectedServiciu
        {
            get { return _selectedServiciu; }
            set
            {
                _selectedServiciu = value;
                OnPropertyChanged("SelectedServiciu");
            }
        }
        public ObservableCollection<string> Servicii { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        private async void RemoveServiceFunction(object parameter)
        {
            using (var dbContext = new BookingContext())
            {
                ServiciuRepository serviciuRepository = new ServiciuRepository(dbContext);
                if (serviciuRepository.DeleteServiciu(SelectedServiciu) == true)
                {
                    UnitOfWork unitOfWork = new UnitOfWork(dbContext);
                    await unitOfWork.SaveChangesAsync();
                    MessageBox.Show("Serviciul s-a sters cu succes!");
                    return;
                }
                MessageBox.Show("Stergerea nu s-a putut efectua!");
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

        public RemoveServiceViewModel()
        {
            using (var dbContext = new BookingContext())
            {
                ServiciuRepository serviciuRepository = new ServiciuRepository(dbContext);
                Servicii = new ObservableCollection<string>(from serviciu in serviciuRepository.GetAll() where serviciu.DeletedAt == false select serviciu.Nume);
            }
        }
    }
}
