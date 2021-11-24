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
using System.IO;


namespace Lab14_WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product()
            {
                Name = "Хлеб",
                Price = 30,
                Image = "Data/хлеб.png",
              
                Category = Category.Food
            });
            products.Add(new Product()
            {
                Name = "Молоко",
                Price = 50,
                Image ="Data/молоко.png",
                Category = Category.Food
            });
            products.Add(new Product()
            {
                Name = "Тостер",
                Price = 2000,
                Image = "Data/тостер.png",
                Category = Category.Appliance
            });
            products.Add(new Product()
            {
                Name = "Чайник",
                Price = 3000,
                Image = "Data/чайник.png",
                Category = Category.Appliance
            });
            lstBox.ItemsSource = products;
        }
    }
}
