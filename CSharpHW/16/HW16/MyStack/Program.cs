using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Pop();
            var stack = myStack.ToArray();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(myStack.Peek());

            Console.ReadLine();
        }
    }
}
