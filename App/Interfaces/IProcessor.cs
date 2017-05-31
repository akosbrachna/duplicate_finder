using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace duplicate_finder.App
{
    interface IProcessor
    {
        void Start(Config config, List<Input> input);
    }
}
