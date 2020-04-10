using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateDemo
{
    public struct Book
    {
        public string Title;
        public string Author;
        public decimal Price;
        public bool IsPaperBack;



        public Book(string title, string author, decimal price, bool isPaperBack)
        {
            Title = title;
            Author = author;
            Price = price;
            IsPaperBack = isPaperBack;
        }

    }
}
