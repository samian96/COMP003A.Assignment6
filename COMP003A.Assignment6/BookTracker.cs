using System;
using System.Collections.Generic;
using System.Text;

namespace COMP003A.Assignment6
{
    internal class BookTracker
    {
        string Name;

        int File;

        private BookTracker(string name, int file)
        {
            Name = name;

            File = file;
        }
    }
}
