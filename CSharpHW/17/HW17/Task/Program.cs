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
            ConcreteAggregate<int> numAggregate = new ConcreteAggregate<int>
            {
                [0] = 1,
                [1] = 2,
                [2] = 3,
                [3] = 4
            };
            ConcreteAggregate<string> stringAggregate = new ConcreteAggregate<string>
            {
                [0] = "first",
                [1] = "second",
                [2] = "third",
                [3] = "fourth"
            };


            var numIterator = new ConcreteIterator<int>(numAggregate);
            var stringIterator = new ConcreteIterator<string>(stringAggregate);

            Console.WriteLine("Iterating over collection of Int:");

            var currNum = numIterator.First();
            do
            {
                currNum = numIterator.Next();
                Console.WriteLine(currNum);
           }
            while (!numIterator.IsDone());

            var currString = stringIterator.First();
            while (!stringIterator.IsDone())
            {
                currString = stringIterator.Next();
                Console.WriteLine(currString);
                
            }

            Console.ReadKey();
        }
    }
}
