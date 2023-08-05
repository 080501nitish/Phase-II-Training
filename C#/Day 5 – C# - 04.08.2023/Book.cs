using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book
    {
        private readonly int bookId;
        private string Title;
        private string Author;
        private bool IsAvailable;

        public Book(int bookId, string title, string author,bool IsAvailable)
        {
            this.bookId = bookId;
            Title1 = title;
            Author1 = author;
            IsAvailable1 = IsAvailable;
        }
        public string Title1 { get => Title; set => Title = value; }
        public string Author1 { get => Author; set => Author = value; }
        public bool IsAvailable1 { get => IsAvailable; set => IsAvailable = value; }

        
        
    }
}
