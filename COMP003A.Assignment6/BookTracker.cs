using System;
using System.Collections.Generic;
using System.Text;

namespace COMP003A.Assignment6
{
    internal class BookTracker
    {
        public string Book;

        public int Page;

        public bool Available;



        private BookTracker(string book, int page, bool available)
        {
            Book = book;

            Page = page;

            Available = available;
        }

        public void DisplayMessage()
        {
            Console.WriteLine("Title: " + Book);

            Console.WriteLine("Pages: " + Page);

            Console.WriteLine("Availability: " + Available);
            if (!Available)
            {
                Console.WriteLine("Unavailable");
            }
            else
            {
                Console.WriteLine("Available");
            }
        }
    }
}
