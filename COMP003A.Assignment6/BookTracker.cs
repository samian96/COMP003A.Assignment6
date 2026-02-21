using System;
using System.Collections.Generic;
using System.Text;

namespace COMP003A.Assignment6
{
    internal class BookTracker
        /* The class BookTracker is here to hold the different data types for the books, how many pages, as well as the availability
         * this will be called to from the main class, this helps clean up the main code from becoming too cluttered.
         * Though my main code is still somewhat cluttered this class still cuts down on the clutter.
         */
    {
        public string Book;

        public int Page;

        public bool Instock;



        public BookTracker(string book, int page, bool available)
        {
            Book = book;

            Page = page;

            Instock = available;
        }

        public void DisplayMessage()
        {
            Console.Write("" + "Title: " + Book + " / ");

            Console.Write("" + "Pages: " + Page + " / ");

            Console.Write("" + "Instock: ");
            if (Instock)
            {
                Console.Write("Available");
            }
            else
            {
                Console.Write("Unavailable");
            }
        }

    }
}
