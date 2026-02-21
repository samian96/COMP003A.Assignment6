using System;
using System.Collections.Generic;
using System.Text;

namespace COMP003A.Assignment6
{
    internal class BookTracker
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
