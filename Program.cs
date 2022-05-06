using System;
using Upcasting_Downcasting.Models;

namespace Upcasting_Downcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Iprintable pdf = new PDF();

            Iprintable word = new Word();

            Iprintable excel = new Excel();

            MainPrintFile word_file = new MainPrintFile(word);
            MainPrintFile excel_file = new MainPrintFile(excel);
            MainPrintFile pdf_file = new MainPrintFile(pdf);
        }
    }
}
