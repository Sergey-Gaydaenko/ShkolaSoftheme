using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class PhotoPrinter : Printer
    {
        public override void Print(string message)
        {
            Console.WriteLine("Class PhotoPrinter");
            Console.WriteLine(message);
        }
        public void Print(string message, string photo)
        {
            Console.WriteLine(message + "   Some photo {0}", photo);
        }
    }
}
