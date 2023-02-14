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
    /// Логика взаимодействия для AccountUser.xaml
    /// </summary>
    public partial class AccountUser : Page
    {
        public AccountUser()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            string Login = txbFLogin.Text;
            string Password = txbPassword.Text;

            db.Client.Add(new Client());
            {
                
            }
        }
    }
}
