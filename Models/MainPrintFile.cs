using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting_Downcasting.Models
{
    class MainPrintFile
    {
        public MainPrintFile(Iprintable iprintable)
        {
            iprintable.Print();
        }
    }
}
