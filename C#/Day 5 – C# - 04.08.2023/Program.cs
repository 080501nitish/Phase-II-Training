using Library;
using System.Collections;


Book book1 = new Book(1, "PS", "Kalki", true);
Book book2 = new Book(2, "Twilight", "Stephnie Mayor", true);
Book book3 = new Book(3, "Harry Potter", "JK Rowling", false);

List<Book> Books = new List<Book>();
Books.Add(book1);
Books.Add(book2);
Books.Add(book3);
LibraryClass lib=new LibraryClass(Books);
lib.ReturnBook(book3);
lib.BorrowBook(book1);
lib.PrintBook();
