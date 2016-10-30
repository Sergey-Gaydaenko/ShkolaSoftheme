using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] message = {"Message 1", " Message 2"};
            ConsoleColor[] color = {ConsoleColor.DarkRed, ConsoleColor.Yellow};
            string[] photos = {"Small dog", "Fat cat"};
            var printer = new Printer();
            printer.ExtPrint(message);

            Console.WriteLine();
            var colourPrinter = new ColourPrinter();
            colourPrinter.ExtPrint(message, color);

            Console.WriteLine();
            var photoPrinter = new PhotoPrinter();
            photoPrinter.ExtPrint(message, photos);

            Console.ReadLine();
        }
    }
}
