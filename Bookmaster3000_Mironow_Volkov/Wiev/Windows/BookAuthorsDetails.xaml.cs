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
    /// Логика взаимодействия для BookAuthorsDetails.xaml
    /// </summary>
    public partial class BookAuthorsDetails : Window
    {
        public BookAuthorsDetails(BookList selectedBook)
        {
            InitializeComponent();


            if (selectedBook != null)
            {
                DataContext = selectedBook;
            }
            AuthorsCMB.Items.Add(selectedBook.Authors.Name);
            AuthorsCMB.SelectedItem = 0;
        }

        private void CloseBtn4_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void AuthorsLink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {

        }
    }
}
