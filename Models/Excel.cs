using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting_Downcasting.Models
{
    class Excel : Iprintable
    {
        public void Print()
        {
            Console.WriteLine("Excel printed");
        }
    }
}
