using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Sergey";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello, " + name);

            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
