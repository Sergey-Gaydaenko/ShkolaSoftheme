using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    internal interface IStack<T>
    {
        void Pop();
        void Push(T item);
        T Peek();
    }
}
