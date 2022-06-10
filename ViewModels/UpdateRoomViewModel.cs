using booking.Database;
using booking.Database.Models;
using booking.Database.Repository;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace booking.ViewModels
{
    class UpdateRoomViewModel : INotifyPropertyChanged
    {
        private ICommand m_updateRoom;

        private string _selectedCamera;
        public string SelectedCamera
        {
            get { return _selectedCamera; }
            set
            {
                _selectedCamera = value;
               
                using (var dbContext = new BookingContext())
                {
                    CameraRepository cameraRepository = new CameraRepository(dbContext);
                    ImagineRepository imagineRepository = new ImagineRepository(dbContext);
                    DotareRepository dotareRepository = new DotareRepository(dbContext);
                    List<Camera> camere = cameraRepository.GetCamere();
                    List<Imagine> imagini = imagineRepository.GetImagine();
                    Camera currentCamera = new Camera();
                    foreach (var camera in camere)
                        if (camera.Nume == _selectedCamera)
                        {
                            currentCamera = camera;
                            break;
                        }
                    Imagine imagine = new Imagine();
                    foreach (var img in imagini)
                        if (img.IdCamera == currentCamera.Id)
                        {
                            imagine = img;
                            break;
                        }
                    NumarCamere = currentCamera.NrCamere;
                    Capacitate = currentCamera.Capacitate;
                    CurrentImagePath = imagine.Path;
                  //  Dotari = new ObservableCollection<DotareCamera>(from dotare in dotareRepository.GetAll() where dotare. select camera.Nume);

                }
                OnPropertyChanged("SelectedCamera");
            }
        }

        private int _numarCamere;
        public int NumarCamere
        {
            get { return _numarCamere; }
            set
            {
                _numarCamere = value;
                OnPropertyChanged("NumarCamere");
            }
        }
        private string _currentImagePath;
        public string CurrentImagePath
        {
            get { return _currentImagePath; }
            set
            {
                _currentImagePath = value;
                OnPropertyChanged("CurrentImagePath");
            }
        }
        private int _capacitate;
        public int Capacitate
        {
            get { return _capacitate; }
            set
            {
                _capacitate = value;
                OnPropertyChanged("Capacitate");
            }
        }

        

        public ObservableCollection<string> Camere { get; set; }
        public ObservableCollection<DotareCamera> Dotari { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        private void UpdateRoomFunction(object parameter)
        {
            using (var dbContext = new BookingContext())
            {
                CameraRepository cameraRepository = new CameraRepository(dbContext);
                if (cameraRepository.DeleteCamera(SelectedCamera).Result == true)
                {
                    MessageBox.Show("Camera s-a editat cu succes!");
                    return;
                }
                MessageBox.Show("Editarea nu s-a putut efectua!");
            }
        }

        public ICommand RemoveRoom
        {
            get
            {
                if (m_updateRoom == null)
                    m_updateRoom = new RelayCommand(UpdateRoomFunction);
                return m_updateRoom;
            }
        }

        public UpdateRoomViewModel()
        {
            using (var dbContext = new BookingContext())
            {
                CameraRepository cameraRepository = new CameraRepository(dbContext);
                Camere = new ObservableCollection<string>(from camera in cameraRepository.GetAll() where camera.DeletedAt == false select camera.Nume);
               

            }
        }
    }
}
