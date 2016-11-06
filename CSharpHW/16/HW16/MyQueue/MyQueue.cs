using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class MyQueue<T> : IQueue<T>
    {
        private Node<T> _headNode;
        private int _count;
        public void Dequeue()
        {
            if (_headNode != null)
            {
                _headNode = _headNode.PrevNode;
                _count--;
            }
            else
            {
                throw new NullReferenceException("Queue is Empty");
            }
        }

        public void Enqueue(T item)
        {
            Node<T> _currentNode = new Node<T>(item);
            if (_headNode == null)
            {
                _headNode = _currentNode;
            }
            else
            {
                Node<T> tempNode = _headNode;

                while (tempNode.PrevNode != null)
                {
                    tempNode = tempNode.PrevNode;
                }
                tempNode.PrevNode = _currentNode;
            }
            _count++;
        }

        public T Peek()
        {
            if (_headNode != null)
            {
                return _headNode.Data;
            }
            else
            {
                throw new NullReferenceException("Queue is Empty");
            }
        }

        public T[] ToArray()
        {
            T[] Arr = new T[_count];

            Node<T> temp = new Node<T>(_headNode.Data);
            temp.PrevNode = _headNode.PrevNode;
            for (int i = 0; i < _count; i++)
            {
                Arr[i] = temp.Data;
                temp = temp.PrevNode;
            }
            return Arr;
        }
        public int GetLenght()
        {
            return _count;
        }
    }
}
