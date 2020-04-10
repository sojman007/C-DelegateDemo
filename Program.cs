using System;

namespace DelegateDemo
{
    class Program
    {

        static void PrintBookTitle(Book book)
        {
            Console.WriteLine($"The title of this book is {book.Title}");
        }

        static void Main(string[] args)
        {
            BookDb MyBookDb = new BookDb();
            AddBooks(MyBookDb);
            
            // PrintBookTitle is the first implementation for the ProcessBookDelegate delegate
            MyBookDb.ProcessPaperbackBooks(PrintBookTitle);


            BookCashier PriceTotaller = new BookCashier();

            // AddBookToTotal is the second implementation for the ProcessBookDelegate delegate
            MyBookDb.ProcessPaperbackBooks(PriceTotaller.AddBookToTotal);

            Console.WriteLine("Average Paperback Book Price: ${0:#.##}",
                    PriceTotaller.GetAverage());

        }



        //add books
        static void AddBooks(BookDb bookDB)
        {
            bookDB.AddBook("The C Programming Language", "Brian W. Kernighan and Dennis M. Ritchie", 19.95m, true);
            bookDB.AddBook("The Unicode Standard 2.0", "The Unicode Consortium", 39.95m, true);
            bookDB.AddBook("The MS-DOS Encyclopedia", "Ray Duncan", 129.95m, false);
            bookDB.AddBook("Dogbert's Clues for the Clueless", "Scott Adams", 12.00m, true);
        }

    }
}
