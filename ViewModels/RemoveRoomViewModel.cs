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
    class RemoveRoomViewModel : INotifyPropertyChanged
    {
        
        public ObservableCollection<string> Camere { get; set; }
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
        

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        private ICommand m_removeRoom;

        private async void RemoveRoomFunction(object parameter)
        {
            using (var dbContext = new BookingContext())
            {
                CameraRepository cameraRepository = new CameraRepository(dbContext);
                if (cameraRepository.DeleteCamera(SelectedCamera).Result == true)
                {
                    UnitOfWork unitOfWork = new UnitOfWork(dbContext);
                    await unitOfWork.SaveChangesAsync();
                    MessageBox.Show("Camera s-a sters cu succes!");
                    return;
                }
                MessageBox.Show("Stergerea nu s-a putut efectua!");
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

        public RemoveRoomViewModel()
        {
            using (var dbContext = new BookingContext())
            {
                CameraRepository camereRepository = new CameraRepository(dbContext);
                Camere = new ObservableCollection<string>(from camera in camereRepository.GetAll() where camera.DeletedAt == false select camera.Nume);
            }
        }
    }
}
