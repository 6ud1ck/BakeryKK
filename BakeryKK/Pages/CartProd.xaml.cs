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
using BakeryKK.Pages;
using BakeryKK.Model;


namespace BakeryKK.Pages
{
    /// <summary>
    /// Логика взаимодействия для CartProd.xaml
    /// </summary>
    public partial class CartProd : Page
    {
        public CartProd()
        {
            InitializeComponent();

            LvCartProduct.ItemsSource = Model.CartProductClass.products;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBuyProduct_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
