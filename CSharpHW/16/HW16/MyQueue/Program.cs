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
            Console.WriteLine("_________________________________\nQueue:");

            MyQueue<int> myQueue = new MyQueue<int>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Dequeue();
            myQueue.Dequeue();
            myQueue.Enqueue(4);
            var queue = myQueue.ToArray();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(myQueue.Peek());

            Console.ReadLine();
        }
    }
}
