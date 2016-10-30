using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrWrapper<int> arrInt = new ArrWrapper<int>();
            arrInt.Add(5);
            arrInt.Add(10);

            Console.WriteLine("10 in array? " + arrInt.Contains(10));
            Console.WriteLine("55 in array? " + arrInt.Contains(55));
            Console.WriteLine("Elemen with index 1 is "+arrInt.GetByIndex(1));

            Console.ReadLine();
        }
    }
}
