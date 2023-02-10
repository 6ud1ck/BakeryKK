using BakeryKK.Model;
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

namespace BakeryKK.Pages
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            var CurrentUser = AppData.db.Register.FirstOrDefault(u => u.Login == txbLogin.Text && u.Password == txbPassword.Text);
            if (CurrentUser != null)
            {
                Authorization authPages = new Authorization();
                
            }
            else
            {
                MessageBox.Show("Данного пользователя нет в базе данных!!!");
            }
        }

        private void btnRegAccount_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Registration.Registration());
        }
    }
}
