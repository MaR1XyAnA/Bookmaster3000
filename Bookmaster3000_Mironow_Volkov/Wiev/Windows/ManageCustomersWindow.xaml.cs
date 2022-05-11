using Bookmaster3000_Mironow_Volkov.AppData;
using Bookmaster3000_Mironow_Volkov.Model;
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
using System.Windows.Shapes;

namespace Bookmaster3000_Mironow_Volkov.Wiev.Windows
{
    /// <summary>
    /// Логика взаимодействия для ManageCustomersWindow.xaml
    /// </summary>
    public partial class ManageCustomersWindow : Window
    {
        private Customers customers = new Customers();
        public ManageCustomersWindow()
        {
            InitializeComponent();
        }

        //private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        //{
         
        //}

        //private void Windows_Loaded(object sender, RoutedEventArgs e)
        //{
            
        //}

        private void CustomersLV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            customers = (Customers)CustomersLV.SelectedItem;
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            EddEditCustomerWindows eddEditCustomerWindows = new EddEditCustomerWindows(customers);
            eddEditCustomerWindows.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CustomersLV.ItemsSource = HelpModel.GetContext().Customers.ToList();
        }

        private void EddButton_Click(object sender, RoutedEventArgs e)
        {
            EddEditCustomerWindows eddEditCustomerWindows = new EddEditCustomerWindows(null);
            eddEditCustomerWindows.Show();
        }
    } 
}
