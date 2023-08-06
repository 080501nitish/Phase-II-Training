using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class LibraryClass
    {
        private readonly List<Book> book;
        public LibraryClass(List<Book> book)
        {
            this.book = book;

        }

        internal List<Book> Book => book;

        public void BorrowBook(Book book)
        {
            if (book.IsAvailable1 == true)
            {
                Console.WriteLine("Book Borrowed");
                book.IsAvailable1 = false;
            }
            else
            {
                Console.WriteLine("Book is not Available");
            }
        }

        public void ReturnBook(Book book)
        {
            if (book.IsAvailable1 == false)
            {
                Console.WriteLine("Book Returned");
                book.IsAvailable1 = true;
            }
            else
            {
                Console.WriteLine("Book is not Available");
            }
        }

        public void PrintBook()
        {
            foreach (Book book in book)
            {
                if (book.IsAvailable1 == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Book Details");
                    Console.WriteLine(book.Title1);
                    Console.WriteLine(book.Author1);
                    Console.WriteLine(book.IsAvailable1);
                }
            }
        }
    }
}
