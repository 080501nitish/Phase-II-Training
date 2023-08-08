using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Bank_2
{
    internal class Library
    {
        private readonly List<Book> books= new List<Book>();
       
        public Library()
        {
            books.Add(new Book(1, "PS", "Kalki", true));
            books.Add(new Book(2, "Twilight", "Stephnie Mayor", true));
            books.Add(new Book(3, "Harry Potter", "JK Rowling", true));
            books.Add(new Book(4, "Lord of the rings", "J.R.R.Tolkien", true));
        }

        internal List<Book> Books => books;

        int count = 0;

        public void BorrowBook(string title)
        {
            foreach (var book in Books)
            {
                if (book.Title.Equals(title) && book.IsAvailable)
                {
                    book.LendItem(title);
                    Console.WriteLine($"{book.Title} has been borrowed.");
                    return;
                }
            }
            Console.WriteLine($"Book {title} is either not available or does not exist in library.");

        }
        int rcount = 0;
        public void ReturnBook(string title)
        {
            foreach (var book in Books)
            {
                if (book.Title.Equals(title) && !book.IsAvailable)
                {
                    book.IsAvailable = true;
                    Console.WriteLine($"{book.Title} has been returned.");
                    return;
                    
                    
                }
                
            }
            Console.WriteLine($"Book {title} is either not available or does not exist in library.");
        }
        public void DisplayAvailableBooks()
        {
            foreach (var book in Books)
            {
                if (book.IsAvailable)
                {
                    Console.WriteLine(book.BookId + " " + book.Title + " " + book.Author);
                    Console.WriteLine();
                }
            }
        }
    }
}
