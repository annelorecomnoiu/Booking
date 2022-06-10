using booking.Database;
using booking.Database.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace booking.ViewModels
{
    class RegisterPageViewModel : INotifyPropertyChanged
    {
        private ICommand m_registerUser;

        private string _userNameInput;
        public string UserNameInput
        {
            get { return _userNameInput; }
            set
            {
                _userNameInput = value;
                OnPropertyChanged("UserNameInput");
            }
        }

        private string _passwordInput;
        public string PasswordInput
        {
            get { return _passwordInput; }
            set
            {
                _passwordInput = value;
                OnPropertyChanged("PasswordInput");
            }
        }

        private ComboBoxItem _roleInput;
        public ComboBoxItem RoleInput
        {
            get { return _roleInput; }
            set
            {
                _roleInput = value;
                OnPropertyChanged("RoleInput");
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
        private async void RegisterUserFunction(object parameter)
        {
            using (var dbContext = new BookingContext())
            {
                UserRepository userRepository = new UserRepository(dbContext);
                if (userRepository.Register(UserNameInput, PasswordInput, RoleInput.Content.ToString()) == true)
                {
                    UnitOfWork unitOfWork = new UnitOfWork(dbContext);
                    await unitOfWork.SaveChangesAsync();
                    MessageBox.Show("Inregistrarea s-a facut cu succes!");
                    return;
                }
                MessageBox.Show("Inregistrarea nu s-a putut efectua, va rog incercati un alt username!");
            }

        }

        public ICommand RegisterUser
        {
            get
            {
                if (m_registerUser == null)
                    m_registerUser = new RelayCommand(RegisterUserFunction);
                return m_registerUser;
            }
        }
    }
}
