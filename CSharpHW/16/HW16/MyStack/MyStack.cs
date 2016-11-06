using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    public class MyStack<T> : IStack<T>
    {
        private Node<T> _tailNode;
        private int _count;
        public void Pop()
        {
            if (_tailNode != null)
            {
                _tailNode = _tailNode.NextNode;
                _count--;
            }
            else
            {
                Console.WriteLine("Stack is Empty");
            }

        }

        public void Push(T item)
        {
            Node<T> _currentNode = new Node<T>(item);

            if (_tailNode == null)
            {
                _tailNode = _currentNode;
            }
            else
            {
                _currentNode.NextNode = _tailNode;
                _tailNode = _currentNode;
            }
            _count++;
        }

        public T Peek()
        {
            if (_tailNode != null)
            {
                return _tailNode.Data;
            }
            else
            {
                Console.WriteLine("Stack is empty");
            }
            throw new NullReferenceException();
        }

        public T[] ToArray()
        {
            T[] Arr = new T[_count];

            Node<T> temp = _tailNode;
            temp.NextNode = _tailNode.NextNode;

            for (int i = 0; i < _count; i++)
            {
                Arr[i] = temp.Data;
                temp = temp.NextNode;
            }
            return Arr;
        }
        public int GetLenght()
        {
            return _count;
        }
    }
}
