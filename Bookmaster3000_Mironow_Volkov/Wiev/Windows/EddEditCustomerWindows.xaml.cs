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
    /// Логика взаимодействия для EddEditCustomerWindows.xaml
    /// </summary>
    public partial class EddEditCustomerWindows : Window
    {

        public EddEditCustomerWindows(Customers customers)
        {
            InitializeComponent();

            if (customers != null)
            {
                DataContext = customers;
                AddBtn.Visibility = Visibility.Collapsed;
                SaveBtn.Visibility = Visibility.Visible;
            }
            else
            {
                IdTB.Text = CountID.Create();
                SaveBtn.Visibility = Visibility.Collapsed;
                AddBtn.Visibility = Visibility.Visible;
            }

        }

        private void CencelBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PhoneTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PhoneTB.Text.Length == 11) 
            {
                long number = long.Parse(PhoneTB.Text);
                PhoneTB.Text = string.Format("{0:#(###)### ## ##}", number);
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Customers customers = new Customers()
                {
                    Id = IdTB.Text,
                    Name = NameTB.Text,
                    Address = AddressTB.Text,
                    Zip = ZipTB.Text,
                    City = CityTB.Text,
                    Phone = PhoneTB.Text,
                    Email = EmailTB.Text
                };
                HelpModel.GetContext().Customers.Add(customers);
                HelpModel.GetContext().SaveChanges();
                MessageBox.Show("ПОЛЬЗОВАТЕЛЬ ЖОБАВЛЕН", "НАШИ ПОЗДРАВЛЕНИЯ");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
