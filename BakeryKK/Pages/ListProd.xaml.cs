using BakeryKK.Model;
using BakeryKK.Pages.EditProd;
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
using BakeryKK.Pages.EditProd;

namespace BakeryKK.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListProd.xaml
    /// </summary>
    public partial class ListProd : Page
    {
        public ListProd()
        {
            InitializeComponent();

            GetListProduct();
        }

        private void GetListProduct()
        {
            List<Product> products = new List<Product>();
            products = db.Product.ToList();

            // поиск, сортировка, фильтрация

            LvProduct.ItemsSource = products;
        }

        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            AddEdit addEditProductWindow = new AddEdit();
            NavigationService.Navigate(new EditProd.AddEdit());
        }
        private void BtnAddProduct_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.EditProd.AddEdit());
        }

        private void BtnEditProduct_Click_1(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null)
            {
                return;
            }

            var product = button.DataContext as Product;


            NavigationService.Navigate(new Pages.EditProd.AddEdit());
        }

        private void btnAddToCartProduct_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
