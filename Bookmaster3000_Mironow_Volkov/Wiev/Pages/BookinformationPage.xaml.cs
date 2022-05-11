using Bookmaster3000_Mironow_Volkov.Model;
using Bookmaster3000_Mironow_Volkov.Wiev.Windows;
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
    /// Логика взаимодействия для BookinformationPage.xaml
    /// </summary>
    public partial class BookinformationPage : Page
    {
        private BookList selectedBook = new BookList();
        public BookinformationPage(BookList selectedBook)
        {
            InitializeComponent();
           
            
            if (selectedBook != null)
            {
                selectedBook = selectedBook;
                DataContext = selectedBook;
            }
        }

        private void Perexod_Click(object sender, RoutedEventArgs e)
        {
            BookAuthorsDetails bookAuthorsDetails = new BookAuthorsDetails(selectedBook);
            bookAuthorsDetails.Show();
        }
    }
}
