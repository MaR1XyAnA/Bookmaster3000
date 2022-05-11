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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bookmaster3000_Mironow_Volkov.Wiev.Pages
{
    /// <summary>
    /// Логика взаимодействия для BooksListPage.xaml
    /// </summary>
    public partial class BooksListPage : Page
    {
        public BooksListPage()
        {
            InitializeComponent();
        }

        private void BooksList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BookList selectedBook = (BookList)BooksList.SelectedItem;
            NavigationHelper.SelectedBookFrame.Navigate(new BookinformationPage(selectedBook)); 
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                BooksList.ItemsSource = HelpModel.GetContext().BookList.ToList();
                BooksCountTb.Text = HelpModel.GetContext().BookList.Count().ToString() + " books fonnd"; //Подсчёт количество элементов в tables booksitems
            }
        }
    }
}
