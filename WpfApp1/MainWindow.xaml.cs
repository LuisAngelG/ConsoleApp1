using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Business;
using Entity;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private BProduct productBusiness;
        public MainWindow()
        {
            InitializeComponent();
            productBusiness = new BProduct();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string productName = TextBoxNombreProducto.Text;

            List<Product> products = productBusiness.GetByName(productName);

            listViewResultados.ItemsSource = products;
        }
    }
}
