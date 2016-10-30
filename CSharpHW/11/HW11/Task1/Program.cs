using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var mess = "Some message";
            var print = new Printer();
            print.Print(mess+"\n");

            var colourPrint = new ColourPrinter();
            colourPrint.Print(mess);
            colourPrint.Print(mess, ConsoleColor.Blue);

            Console.WriteLine();
            var photoPrint = new PhotoPrinter();
            photoPrint.Print(mess);
            photoPrint.Print(mess,"Cute cat");

            Console.ReadLine();
        }
    }
}
