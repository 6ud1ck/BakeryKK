using BakeryKK.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для ProductList.xaml
    /// </summary>
    public partial class ProductList : Page
    {
        public ProductList()
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

        private void BtnEditProduct_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null)
            {
                return;
            }

            var product = button.DataContext as Product;

            AddEdit addEditProductWindow = new AddEdit();
            NavigationService.Navigate(new EditProd.AddEdit());
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
