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
    /// Логика взаимодействия для WelcomPage.xaml
    /// </summary>
    public partial class WelcomPage : Page
    {
        public WelcomPage()
        {
            InitializeComponent();
        }

        private void btnBackToAuth_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
