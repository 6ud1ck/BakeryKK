using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static BakeryKK.Model.AppData;
using BakeryKK.Model;

namespace BakeryKK.Pages.Registration
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
            
        }

        public void btnNextReg_Click(object sender, RoutedEventArgs e)
        {

            string genderCode;
            if (rbMan.IsChecked == true)
            {
                genderCode = "м";
            }
            else
            {
                genderCode = "ж";
            }
            

            string Login = txbFLogin.Text;
            string Password = txbPassword.Text;

            // добавление пользоватля в таблицу client

            db.Client.Add(new Model.Client
            {
                FirstName = txbFName.Text,
                LastName = txbLName.Text,
                Patronymic = txbPatronymic.Text,
                Phone = txbPhone.Text,
                Gender = genderCode,


            });

            //добавления логина и пароля в таблицу регистрация

            db.Register.Add(new Model.Register
            {
                Login = txbFLogin.Text,
                Password = txbPassword.Text
            });
            
            db.SaveChanges();

            NavigationService.Navigate(new AccountUser());
        }

        private void rbMan_Click(object sender, RoutedEventArgs e)
        {
            if (rbMan.IsChecked == true)
            {
                rbWoman.IsChecked = false;
            }
            else if (rbWoman.IsChecked == true)
            {
                rbMan.IsChecked = false;
            }
        }

        private void rbWoman_Click(object sender, RoutedEventArgs e)
        {
            if (rbMan.IsChecked == true)
            {
                rbWoman.IsChecked = false;
            }
            else if (rbWoman.IsChecked == true)
            {
                rbMan.IsChecked = false;
            }
        }
    }
}
