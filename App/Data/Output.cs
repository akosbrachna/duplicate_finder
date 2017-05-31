using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace duplicate_finder.App
{
    public class myList
    {
        public string name;
        public string duplicate;
        public long file_size;
        public double proximity;

        public myList(string name, string duplicate, long file_size, double proximity)
        {
            this.name = name;
            this.duplicate = duplicate;
            this.file_size = file_size;
            this.proximity = proximity;
        }
    }
}
