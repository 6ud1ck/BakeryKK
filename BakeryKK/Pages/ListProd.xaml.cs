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
using static BakeryKK.ClassHelper.EFClass;
using BakeryKK.Pages;
using BakeryKK.Windows;

namespace BakeryKK.Pages
{
    
    public partial class ListProd : Page
    {
        List<string> strings = new List<string>()
        {
            "По умолчанию",
            "По возрастанию",
            "По убыванию",
            "По цене",
            "В наличии"

        };

        public ListProd()
        {
            InitializeComponent();

            cmbSort.ItemsSource = strings;
            cmbSort.SelectedIndex = 0;

            GetListProduct();
        }

        private void GetListProduct()
        {
            List<Product> products = new List<Product>();
            products = db.Product.ToList();

            var StartIndex = cmbSort.SelectedIndex;

            // поиск, сортировка, фильтрация


            //Сортировка

            switch (StartIndex)
            {
                case 0:
                    products = products.OrderBy(i => i.ID).ToList();
                    break;
                case 1:
                    products = products.OrderBy(i => i.Title.ToLower()).ToList();
                    break;
                case 2:
                    products = products.OrderByDescending(i => i.Title.ToLower()).ToList();
                    break;
                case 3:
                    products = products.OrderBy(i => i.Cost).ToList();
                    break;
                case 4:
                    products = products.OrderBy(i => i.Quantity).ToList();
                    break;

                default:
                    break;
            }

            LvProduct.ItemsSource = products;
        }

        private void BtnAddProduct_Click_1(object sender, RoutedEventArgs e)
        {
            EditWindow editWindow = new EditWindow();
            editWindow.ShowDialog();
            
        }

        private void BtnEditProduct_Click(object sender, RoutedEventArgs e)
        {

            var button = sender as Button;
            if (button == null)
            {
                return;
            }

            var product = button.DataContext as Product;

            EditWindow editWindow = new EditWindow(product);
            editWindow.ShowDialog();

            GetListProduct();           
        } 

        private void cmbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GetListProduct();
        }
    }
}
