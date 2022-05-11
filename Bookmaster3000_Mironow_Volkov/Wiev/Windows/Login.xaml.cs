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
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (LoginLogo.Text == "admin" && PasswordLogo.Password == "123")
            {
                BrowseCatalogWindow browseCatalogWindow = new BrowseCatalogWindow();
                browseCatalogWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Data entry error ", "Error");
            }   
           
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
