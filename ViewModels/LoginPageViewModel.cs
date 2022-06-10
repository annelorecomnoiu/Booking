using booking.Database;
using booking.Database.Repository;
using booking.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace booking.ViewModels
{
    class LoginPageViewModel : INotifyPropertyChanged
    {
        private ICommand m_registerPage;
        private ICommand m_loginPage;
        private ICommand m_loginAsGuestPage;

        private string _loginUsername;
        public string LoginUsername
        {
            get { return _loginUsername; }
            set
            {
                _loginUsername = value;
                OnPropertyChanged("LoginUsername");
            }
        }

        private string _loginPassword;
        public string LoginPassword
        {
            get { return _loginPassword; }
            set
            {
                _loginPassword = value;
                OnPropertyChanged("LoginPassword");
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

        private void RegisterPage(object parameter)
        {
            var registerPage = new RegisterPage();
            registerPage.Show();
        }

        private void LoginPage(object parameter)
        {
            using (var dbContext = new BookingContext())
            {
                UserRepository userRepository = new UserRepository(dbContext);
                if (userRepository.Login(LoginUsername, LoginPassword) == true)
                {
                    switch (userRepository.VerifyRole(LoginUsername))
                    {
                        case 0:
                            var adminPage = new AdminPage();
                            adminPage.Show();
                            return;
                        case 1:
                            var employeePage = new EmployeePage();
                            employeePage.Show();
                            return;
                        case 2:
                            var clientPage = new ClientPage();
                            clientPage.Show();
                            return;
                        default:
                            return;
                    }
                }
                MessageBoxResult result = MessageBox.Show("Userul sau parola nu sunt corecte");
            }
            
    }

        private void LoginAsGuestPage(object parameter)
        {
            var guestPage = new GuestPage();
            guestPage.Show();
        }

        public ICommand Register
        {
            get
            {
                if (m_registerPage == null)
                    m_registerPage = new RelayCommand(RegisterPage);
                return m_registerPage;
            }
        }

        public ICommand Login
        {
            get
            {
                if (m_loginPage == null)
                    m_loginPage = new RelayCommand(LoginPage);
                return m_loginPage;
            }
        }

        public ICommand LoginAsGuest
        {
            get
            {
                if (m_loginAsGuestPage == null)
                    m_loginAsGuestPage = new RelayCommand(LoginAsGuestPage);
                return m_loginAsGuestPage;
            }
        }
    }
}
