using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BTTH3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePicker : ContentPage
    {
        List<Book> books;
        void BookInit()
        {
            books = new List<Book>();
            books.Add(new Book { bookImg = "conan.jpg", bookTitle = "Conan" });
            books.Add(new Book { bookImg = "doremon.jpg", bookTitle = "Doremon" });
            books.Add(new Book { bookImg = "naruto.jpg", bookTitle = "Naruto" });
            books.Add(new Book { bookImg = "totoro.jpg", bookTitle = "Tonari no Totoro" });
            pickBook.ItemsSource = books;


        }

        void CartInit(string title)
        {
            List<Book> selectedBook = new List<Book>();
            if (title != "")
            {
                foreach(Book book in books)
                {
                    if(book.bookTitle == title)
                    {
                        selectedBook.Add(book);
                    }
                }
                listSelected.ItemsSource = selectedBook;
            }
        }
        public PagePicker()
        {
            InitializeComponent();
            BookInit();
            CartInit("");
        }

        private void pickBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            if(selectedIndex >= 0)
            {
                string title = picker.Items[selectedIndex].ToString();
                CartInit(title);
            }

        }
    }
}