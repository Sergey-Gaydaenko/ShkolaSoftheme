using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ColourPrinter : Printer
    {
        public override void Print(string message)
        {
            Console.WriteLine("Class ColourPrinter");
            Console.WriteLine(message);
        }

        public void Print(string message, ConsoleColor color)
        {
            Console.BackgroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
