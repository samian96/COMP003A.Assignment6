using System;
using System.Collections.Generic;
using System.Text;

namespace COMP003A.Assignment6
{
    internal class BookTracker
    {
        public string Name;

        public int File;

        public bool Available;



        private BookTracker(string name, int file, bool available)
        {
            Name = name;

            File = file;

            Available = available;
        }

        public void DisplayMessage()
        {
            Console.WriteLine("Book: " + Name);

            Console.WriteLine("Available: " + File);

            Console.WriteLine("Avaliable: " + Available);
        }
    }
}
