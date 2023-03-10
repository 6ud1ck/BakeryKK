using BakeryKK.Model;
using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;

namespace BakeryKK.Pages.EditProd
{
    /// <summary>
    /// Логика взаимодействия для AddEdit.xaml
    /// </summary>
    public partial class AddEdit : Page
    {
        private string pathPhoto = null;

        private bool isEdit = false;

        private Product editProduct;



        public AddEdit()
        {
            InitializeComponent();

            CMBTypeProduct.ItemsSource = db.ProductType.ToList();
            CMBTypeProduct.SelectedIndex = 0;
            CMBTypeProduct.DisplayMemberPath = "TypeName";
        }

        public AddEdit(Product product)
        {
            InitializeComponent();

            CMBTypeProduct.ItemsSource = db.ProductType.ToList();
            CMBTypeProduct.SelectedIndex = 0;
            CMBTypeProduct.DisplayMemberPath = "TypeName";

            TbNameProduct.Text = product.Title.ToString();
            TbDisc.Text = product.Description.ToString();
            CMBTypeProduct.SelectedItem = db.ProductType.Where(i => i.ID == product.ProdTypeID).FirstOrDefault();

            using (MemoryStream stream = new MemoryStream(product.Image))
            {
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                bitmapImage.StreamSource = stream;
                bitmapImage.EndInit();
                ImgProduct.Source = bitmapImage;

            }

            isEdit = true;

            editProduct = product;

        }

        private void BtnAddEdit_Click(object sender, RoutedEventArgs e)
        {
            //валидация


            if (isEdit)
            {
                //изменение товара

                editProduct.Title = TbNameProduct.Text;
                editProduct.Description = TbDisc.Text;
                editProduct.ProdTypeID = (CMBTypeProduct.SelectedItem as ProductType).ID;
                if (pathPhoto != null)
                {
                    editProduct.Image = File.ReadAllBytes(pathPhoto);
                }
                db.SaveChanges();
                MessageBox.Show("OK");
            }
            else
            {
                //добавление товара
                Product product = new Product();
                product.Title = TbNameProduct.Text;
                product.Description = TbDisc.Text;
                product.ProdTypeID = (CMBTypeProduct.SelectedItem as ProductType).ID;
                if (pathPhoto != null)
                {
                    product.Image = File.ReadAllBytes(pathPhoto);
                }

                db.Product.Add(product);

                db.SaveChanges();
                MessageBox.Show("OK");
            }


        }

        private void BtnChooseImage_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                ImgProduct.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                pathPhoto = openFileDialog.FileName;
            }

        }

        
    }
}
