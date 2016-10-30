using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var humanOne = new Human(DateTime.Parse("18/01/1996"), "Sergey", "Gaydaenko");
            var humanTwo = new Human(DateTime.Parse("18/01/1996"), "Sergey", "Gaydaenko");
            var humanThree = new Human(DateTime.Parse("01/01/1999"), "Andrey", "Ostapenko");
            if(humanOne.Equals(humanTwo))
                Console.WriteLine("this is one man");
            else
            {
                Console.WriteLine("this humans are different");
            }

            if (humanThree.Equals(humanTwo))
                Console.WriteLine("this is one man");
            else
            {
                Console.WriteLine("this humans are different");
            }
            Console.ReadLine();
        }
    }
}
