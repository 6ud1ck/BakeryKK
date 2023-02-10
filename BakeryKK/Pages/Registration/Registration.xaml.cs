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

        private void btnNextReg_Click(object sender, RoutedEventArgs e)
        {
            string FName = txbFName.Text;
            string LName = txbLName.Text;
            string Patronymic = txbPatronymic.Text;
            if (rbMan.IsChecked == true)
            {
                string gender = "м";
            }
            else
            {
                string gender = "ж";
            }
            string Date = txbDate.Text;
            string Phone = txbPhone.Text;

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
