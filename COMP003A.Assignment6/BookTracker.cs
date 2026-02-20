using System;
using System.Collections.Generic;
using System.Text;

namespace COMP003A.Assignment6
{
    internal class BookTracker
    {
        public string Name;

        public int File;

        public bool Complete;



        private BookTracker(string name, int file, bool complete)
        {
            Name = name;

            File = file;

            Complete =complete
        }
    }
}
