using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateDemo
{
    public class BookCashier
    {
        int totalBookCount =0;
        decimal bookPriceTotal = 0.0M;

      internal void AddBookToTotal(Book book)
        {
            totalBookCount += 1; // increase the book Count whenever this method is called
            bookPriceTotal += book.Price;
        }

      internal decimal GetAverage()
        {
            return bookPriceTotal / totalBookCount;
        }
    }
}
