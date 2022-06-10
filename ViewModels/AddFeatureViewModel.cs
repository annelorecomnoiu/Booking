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
    class AddFeatureViewModel : INotifyPropertyChanged
    {
        private ICommand m_addNewFeature;

        private string _featureName;
        public string FeatureName
        {
            get { return _featureName; }
            set
            {
                _featureName = value;
                OnPropertyChanged("FeatureName");
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

        private async void AddNewFeatureFunction(object parameter)
        {
            using (var dbContext = new BookingContext())
            {
                DotareRepository dotareRepository = new DotareRepository(dbContext);
                if (dotareRepository.AddDotare(FeatureName) == true)
                {
                    UnitOfWork unitOfWork = new UnitOfWork(dbContext);
                    await unitOfWork.SaveChangesAsync();
                    MessageBox.Show("Dotarea s-a adaugat cu succes!");
                    return;
                }
                MessageBox.Show("Adaugarea nu s-a putut efectua, verificati ca aceasta sa nu existe deja in baza de date");
            }
        }

        public ICommand AddNewFeature
        {
            get
            {
                if (m_addNewFeature == null)
                    m_addNewFeature = new RelayCommand(AddNewFeatureFunction);
                return m_addNewFeature;
            }
        }
    }
}
