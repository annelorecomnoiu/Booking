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
    class RemoveOfferViewModel : INotifyPropertyChanged
    {
        private ICommand m_removeOffer;

        private string _selectedOferta;
        public string SelectedOferta
        {
            get { return _selectedOferta; }
            set
            {
                _selectedOferta = value;
                OnPropertyChanged("SelectedOferta");
            }
        }
        public ObservableCollection<string> Oferte { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        private async void RemoveOfferFunction(object parameter)
        {
            using (var dbContext = new BookingContext())
            {
                OfertaRepository ofertaRepository = new OfertaRepository(dbContext);
                if (ofertaRepository.DeleteOferta(SelectedOferta) == true)
                {
                    UnitOfWork unitOfWork = new UnitOfWork(dbContext);
                    await unitOfWork.SaveChangesAsync();
                    MessageBox.Show("Oferta s-a sters cu succes!");
                    return;
                }
                MessageBox.Show("Stergerea nu s-a putut efectua!");
            }
        }

        public ICommand RemoveOffer
        {
            get
            {
                if (m_removeOffer == null)
                    m_removeOffer = new RelayCommand(RemoveOfferFunction);
                return m_removeOffer;
            }
        }

        public RemoveOfferViewModel()
        {
            using (var dbContext = new BookingContext())
            {
                OfertaRepository ofertaRepository = new OfertaRepository(dbContext);
                Oferte = new ObservableCollection<string>(from oferta in ofertaRepository.GetAll() where oferta.DeletedAt == false select oferta.Nume);
            }
        }
    }
}
