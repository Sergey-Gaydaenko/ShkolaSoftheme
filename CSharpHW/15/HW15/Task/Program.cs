using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoLinkedList<int> list = new TwoLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            Console.WriteLine(list.Count());

            Console.WriteLine("2 in list? " + list.Contains(2));
            list.RemoveInPosition(2);
            int[] mass = list.ToArray();
            foreach (var item in mass)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
