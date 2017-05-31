using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace duplicate_finder.App
{
    public class Input
    {
        public string filename;
        public List<int> group;
        public Input(string filename)
        {
            this.filename = filename;
            group = new List<int>();
        }
    }

    public class Config
    {
        public int min_file_size = 50000;
        public double file_size_match_settings = 0.85;
        public double content_match_settings = 0.85;
        public int total_files;
        public double total_size;
    }
}
