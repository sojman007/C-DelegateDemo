using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DelegateDemo
{
    class BookDb
    {
        // List of all books in the database:
        ArrayList list = new ArrayList();
        


        //create a delegate for processing books
        public delegate void ProcessBookDelegate(Book book);

        
        
        // Add a book to the database:
        public void AddBook(string title, string author, decimal price, bool paperBack)
        {
            list.Add(new Book(title, author, price, paperBack));
        }



        // Pass in delegate on each paperback book to process it: 
        public void ProcessPaperbackBooks(ProcessBookDelegate processBook)
        {
            foreach (Book b in list)
            {
                if (b.IsPaperBack)
                    // Calling the delegate:
                    processBook(b);
            }
        }
    
    }
}
