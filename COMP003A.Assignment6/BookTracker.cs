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
            Console.WriteLine($"Title:{Book}");

            Console.WriteLine($"Available:{Page} ");

            Console.WriteLine($"Avaliable:{(Available ? "Yes" : "Mo")}");
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
