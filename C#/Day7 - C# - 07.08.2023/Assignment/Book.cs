using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_2
{
    internal class Book : ILendable
    {
        private readonly int bookId; 
        private string? title;
        private string? author;
        private bool isAvailable;


        public Book(int bookId, string title, string author, bool isAvailable) : base()
        {
            this.bookId = bookId;
            this.Title = title;
            this.Author = author;
            this.IsAvailable = isAvailable;
        }

        public int BookId => bookId;

        public string? Title { get => title; set => title = value; }
        public string? Author { get => author; set => author = value; }
        public bool IsAvailable { get => isAvailable; set => isAvailable = value; }


        public void LendItem(string? title)
        {
            if(Title==title && IsAvailable)
            {
                isAvailable = false;
            }
            else
            {
                isAvailable = true;
            }
        }
    }
}
