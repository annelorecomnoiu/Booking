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
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace booking.ViewModels
{
    class AddRoomViewModel : INotifyPropertyChanged
    {
        private ICommand m_addFeature;
        private ICommand m_removeFeature;
        private ICommand m_addImage;
        private ICommand m_previousImage;
        private ICommand m_nextImage;
        private ICommand m_addRoom;


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

        private string _noOfRooms;
        public string NoOfRooms
        {
            get { return _noOfRooms; }
            set
            {
                _noOfRooms = value;
                OnPropertyChanged("NoOfRooms");
            }
        }

        private ComboBoxItem _roomCapacity;
        public ComboBoxItem RoomCapacity
        {
            get { return _roomCapacity; }
            set
            {
                _roomCapacity = value;
                OnPropertyChanged("RoomCapacity");
            }
        }

        private string _currentImage;
        public string CurrentImage
        {
            get { return _currentImage; }
            set
            {
                _currentImage = value;
                OnPropertyChanged("CurrentImage");
            }
        }

        private string _currentNewFeature;
        public string CurrentNewFeature
        {
            get { return _currentNewFeature; }
            set
            {
                _currentNewFeature = value;
                OnPropertyChanged("CurrentNewFeature");
            }
        }

        private string _currentAddedFeature;
        public string CurrentAddedFeature
        {
            get { return _currentAddedFeature; }
            set
            {
                _currentAddedFeature = value;
                OnPropertyChanged("CurrentAddedFeature");
            }
        }

        public ObservableCollection<string> DotariCamera { get; set; }
        public ObservableCollection<string> DotariAdaugate { get; set; }
        public List<string> ImaginiiCamera { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        private void AddFeatureFunction(object parameter)
        {
            DotariAdaugate.Add(CurrentNewFeature);
            DotariCamera.Remove(CurrentNewFeature);
        }
        private void RemoveFeatureFunction(object parameter)
        {
            DotariCamera.Add(CurrentAddedFeature);
            DotariAdaugate.Remove(CurrentAddedFeature);
        }
        private void AddImageFunction(object parameter)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpg;*.jpeg;*.gif)|*.png;*.jpg;*.jpeg;*.gif|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = "C:\\Users\\User\\Desktop\\booking\\Images";
            if (openFileDialog.ShowDialog() == true)
            {
                string ImageDirectory = "C:\\Users\\User\\Desktop\\booking\\Images\\";
                string newPath = ImageDirectory + RoomName + DateTime.Now.ToBinary() + ".png";
                File.Copy(openFileDialog.FileName, newPath);
                if (ImaginiiCamera.Contains("C:\\Users\\User\\Desktop\\booking\\Images\\noimage.png"))
                    ImaginiiCamera.Remove("C:\\Users\\User\\Desktop\\booking\\Images\\noimage.png");
                ImaginiiCamera.Add(newPath);
                CurrentImage = Path.GetFullPath(newPath);
            }
        }
        private void PreviousImageFunction(object parameter)
        {
            int countImage = ImaginiiCamera.IndexOf("C:\\Users\\User\\Desktop\\booking\\Images\\" + Path.GetFileName(CurrentImage));
            if (countImage - 1 < 0)
            {
                MessageBox.Show("Ati ajuns la prima poza, incercati sa dati next image");
                return;
            }
            CurrentImage = Path.GetFullPath(ImaginiiCamera[countImage - 1]);
        }
        private void NextImageFunction(object parameter)
        {
            int countImage = ImaginiiCamera.IndexOf("C:\\Users\\User\\Desktop\\booking\\Images\\" + Path.GetFileName(CurrentImage));
            if (countImage + 1 >= ImaginiiCamera.Count)
            {
                MessageBox.Show("Ati ajuns la ultima poza, incercati sa dati previous image");
                return;
            }
            CurrentImage = Path.GetFullPath(ImaginiiCamera[countImage + 1]);
        }
        private async void AddRoomFunction(object parameter)
        {
            using (var dbContext = new BookingContext())
            {
                CameraRepository cameraRepository = new CameraRepository(dbContext);
                int RoomCap = Int32.Parse(RoomCapacity.Content.ToString());
                await cameraRepository.AddCamera(RoomName, RoomCap, Int32.Parse(NoOfRooms));
            }

            using (var dbContext = new BookingContext())
            {
                CameraRepository cameraRepository = new CameraRepository(dbContext);
                DotareRepository dotareRepository = new DotareRepository(dbContext);
                DotareCameraRepository dotareCameraRepository = new DotareCameraRepository(dbContext);
                ImagineRepository imagineRepository = new ImagineRepository(dbContext);

                List<Dotare> dotariDB = dotareRepository.GetAll().ToList();
                List<Dotare> dotariDeAdaugatInDB = new List<Dotare>();
                foreach (var dotare in dotariDB)
                {
                    if (DotariAdaugate.Contains(dotare.Nume))
                        dotariDeAdaugatInDB.Add(dotare);
                }
                List<Camera> camereDB = cameraRepository.GetAll().ToList();
                Camera cameraAdaugata = camereDB.Find(c => c.Nume.Equals(RoomName));

                dotareCameraRepository.AddDotari(dotariDeAdaugatInDB, cameraAdaugata);
                imagineRepository.AddImagini(ImaginiiCamera, cameraAdaugata);
                UnitOfWork unitOfWork = new UnitOfWork(dbContext);
                await unitOfWork.SaveChangesAsync();
            }
            MessageBox.Show("Camera a fost adaugata cu succes");
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
        public ICommand AddFeature
        {
            get
            {
                if (m_addFeature == null)
                    m_addFeature = new RelayCommand(AddFeatureFunction);
                return m_addFeature;
            }
        }
        public ICommand AddImage
        {
            get
            {
                if (m_addImage == null)
                    m_addImage = new RelayCommand(AddImageFunction);
                return m_addImage;
            }
        }
        public ICommand NextImage
        {
            get
            {
                if (m_nextImage == null)
                    m_nextImage = new RelayCommand(NextImageFunction);
                return m_nextImage;
            }
        }
        public ICommand PreviousImage
        {
            get
            {
                if (m_previousImage == null)
                    m_previousImage = new RelayCommand(PreviousImageFunction);
                return m_previousImage;
            }
        }
        public ICommand AddRoom
        {
            get
            {
                if (m_addRoom == null)
                    m_addRoom = new RelayCommand(AddRoomFunction);
                return m_addRoom;
            }
        }

        public AddRoomViewModel()
        {
            using (var dbContext = new BookingContext())
            {
                DotareRepository dotareRepository = new DotareRepository(dbContext);
                DotariCamera = new ObservableCollection<string>(from dotare in dotareRepository.GetAll() where dotare.DeletedAt == false select dotare.Nume);
            }
            DotariAdaugate = new ObservableCollection<string>();
            ImaginiiCamera = new List<string>() { "C:\\Users\\User\\Desktop\\booking\\Images\\noimage.png" };
            CurrentImage = Path.GetFullPath("C:\\Users\\User\\Desktop\\booking\\Images\\noimage.png");
        }
    }
}
