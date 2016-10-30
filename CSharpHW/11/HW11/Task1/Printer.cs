using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Printer
    {
        public virtual void Print(string message)
        {
            Console.WriteLine("Base class Printer");
            Console.WriteLine(message);
        }
    }
}
