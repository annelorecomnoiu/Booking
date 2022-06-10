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
    class RemoveFeatureViewModel : INotifyPropertyChanged
    {
        private ICommand m_removeFeature;

        private string _selectedDotare;
        public string SelectedDotare
        {
            get { return _selectedDotare; }
            set
            {
                _selectedDotare = value;
                OnPropertyChanged("SelectedDotare");
            }
        }
        public ObservableCollection<string> Dotari { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        private async void RemoveFeatureFunction(object parameter)
        {
            using (var dbContext = new BookingContext())
            {
                DotareRepository dotareRepository = new DotareRepository(dbContext);
                if (dotareRepository.DeleteDotare(SelectedDotare) == true)
                {
                    UnitOfWork unitOfWork = new UnitOfWork(dbContext);
                    await unitOfWork.SaveChangesAsync();
                    MessageBox.Show("Dotarea s-a sters cu succes!");
                    return;
                }
                MessageBox.Show("Stergerea nu s-a putut efectua!");
            }
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

        public RemoveFeatureViewModel()
        {
            using (var dbContext = new BookingContext())
            {
                DotareRepository dotareRepository = new DotareRepository(dbContext);
                Dotari = new ObservableCollection<string>(from dotare in dotareRepository.GetAll() where dotare.DeletedAt == false select dotare.Nume);
            }
        }
    }
}
