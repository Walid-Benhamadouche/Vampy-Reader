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

namespace Vampy_Reader
{
    /// <summary>
    /// Logique d'interaction pour Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();

            List<Book> Books = new List<Book>();
            Books.Add(new Book("ReZero Vol 01", "C:/Users/Aures/Desktop/WpfDemo/Covers/1.png", 300, 0));
            Books.Add(new Book("Dragon Age - The Masked Empire", "C:/Users/Aures/Desktop/WpfDemo/Dragon Age - The Masked Empire/OEBPS/images/9781466828100.jpg", 300, 0));
            Books.Add(new Book("ReZero Vol 01", "C:/Users/Aures/Desktop/WpfDemo/Covers/1.png", 300, 0));
            Books.Add(new Book("Dragon Age - The Masked Empire", "C:/Users/Aures/Desktop/WpfDemo/Dragon Age - The Masked Empire/OEBPS/images/9781466828100.jpg", 300, 0));
            Books.Add(new Book("ReZero Vol 01", "C:/Users/Aures/Desktop/WpfDemo/Covers/1.png", 300, 0));
            Books.Add(new Book("Dragon Age - The Masked Empire", "C:/Users/Aures/Desktop/WpfDemo/Dragon Age - The Masked Empire/OEBPS/images/9781466828100.jpg", 300, 0));
            Books.Add(new Book("ReZero Vol 01", "C:/Users/Aures/Desktop/WpfDemo/Covers/1.png", 300, 0));
            Books.Add(new Book("Dragon Age - The Masked Empire", "C:/Users/Aures/Desktop/WpfDemo/Dragon Age - The Masked Empire/OEBPS/images/9781466828100.jpg", 300, 0));
            Books.Add(new Book("ReZero Vol 01", "C:/Users/Aures/Desktop/WpfDemo/Covers/1.png", 300, 0));
            Books.Add(new Book("Dragon Age - The Masked Empire", "C:/Users/Aures/Desktop/WpfDemo/Dragon Age - The Masked Empire/OEBPS/images/9781466828100.jpg", 300, 0));
            Books.Add(new Book("ReZero Vol 01", "C:/Users/Aures/Desktop/WpfDemo/Covers/1.png", 300, 0));
            Books.Add(new Book("Dragon Age - The Masked Empire", "C:/Users/Aures/Desktop/WpfDemo/Dragon Age - The Masked Empire/OEBPS/images/9781466828100.jpg", 300, 0));
            Books.Add(new Book("ReZero Vol 01", "C:/Users/Aures/Desktop/WpfDemo/Covers/1.png", 300, 0));
            Books.Add(new Book("Dragon Age - The Masked Empire", "C:/Users/Aures/Desktop/WpfDemo/Dragon Age - The Masked Empire/OEBPS/images/9781466828100.jpg", 300, 0));
            Books.Add(new Book("ReZero Vol 01", "C:/Users/Aures/Desktop/WpfDemo/Covers/1.png", 300, 0));
            Books.Add(new Book("Dragon Age - The Masked Empire", "C:/Users/Aures/Desktop/WpfDemo/Dragon Age - The Masked Empire/OEBPS/images/9781466828100.jpg", 300, 0));
            Books.Add(new Book("ReZero Vol 01", "C:/Users/Aures/Desktop/WpfDemo/Covers/1.png", 300, 0));
            Books.Add(new Book("Dragon Age - The Masked Empire", "C:/Users/Aures/Desktop/WpfDemo/Dragon Age - The Masked Empire/OEBPS/images/9781466828100.jpg", 300, 0));

            BookList.ItemsSource = Books;
        }
    }
}
