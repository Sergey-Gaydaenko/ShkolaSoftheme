using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    interface IQueue<T>
    {
        void Dequeue();
        void Enqueue(T item);
        T Peek();
    }
}
