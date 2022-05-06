using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting_Downcasting.Models
{
    class PDF : Iprintable
    {
        public void Print()
        {
            Console.WriteLine("PDF printed");
        }
    }
}
