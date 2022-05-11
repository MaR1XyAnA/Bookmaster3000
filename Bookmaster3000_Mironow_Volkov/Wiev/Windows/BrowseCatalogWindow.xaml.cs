using Bookmaster3000_Mironow_Volkov.AppData;
using Bookmaster3000_Mironow_Volkov.Wiev.Pages;
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
    /// Логика взаимодействия для BrowseCatalogWindow.xaml
    /// </summary>
    public partial class BrowseCatalogWindow : Window
    {
        public BrowseCatalogWindow()
        {
            InitializeComponent();

            NavigationHelper.BooksListFrame = BooksListFrm; 
            NavigationHelper.SelectedBookFrame = SelectedBookFrm;
            BooksListFrm.Navigate(new BooksListPage());

           //SelectedBookFrm.Navigate(new BookinformationPage());
        }

        private void Customers_Click(object sender, RoutedEventArgs e)
        {
            ManageCustomersWindow manageCustomersWindow = new ManageCustomersWindow();
            manageCustomersWindow.Show();
        }

        private void Circulator_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Reports_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
//BooksMasterDateBaseMironovVolkov - Название базы данных
