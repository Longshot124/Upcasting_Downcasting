using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting_Downcasting.Models
{
    class Word : Iprintable
    {
        public void Print()
        {
            Console.WriteLine("Word printed");
        }
    }
}
