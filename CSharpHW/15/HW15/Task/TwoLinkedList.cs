using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class TwoLinkedList<T>
    {
        private Node<T> _first;
        private Node<T> _last;
        private Node<T> _current; 
        private int _count;

        public TwoLinkedList()
        {
            _first = _last = _current = null;
        }

        public void Add(T item)
        {
            if (_first == null)
            {
                _first = new Node<T>();
                _first.Data = item;
                _last = _first;
            }
            else
            {
                if (_last == null) _last = _first;
                var newNode = new Node<T> { PrevNode = _last, NextNode = null, Data = item };
                _last.NextNode = newNode;
                _last = newNode;
            }
            _count++;
        }

        private void RemoveFirst()
        {
            try
            {
                if (_first == _last)
                {
                    _first = _last = null;
                }
                else
                {
                    _first = _first.NextNode;
                    _first.PrevNode = null;
                }

                _count--;
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }   
        }
        private void RemoveLast()
        {
            try
            {
                if (_first == _last)
                {
                    _first = _last = null;
                }
                else
                {
                    _last = _last.PrevNode;
                    _last.NextNode = null;
                }
                _count--;
            }
            
            catch (Exception)
            {

                Console.WriteLine("Error");
            }
        }
        public void RemoveInPosition(int index)
        {
            Node<T> temp;
            try
            {
                if (index == 0)
                {
                    RemoveFirst();
                }
                else if (index == _count - 1)
                {
                    RemoveLast();
                }
                else
                {
                    int count = 0;
                    _current = _first;
                    while (_current != null && count != index)
                    {
                        _current = _current.NextNode;
                        count++;
                    }

                    if (index == count)
                    {
                        _current.PrevNode.NextNode = _current.NextNode;
                        _current.NextNode.PrevNode = _current.PrevNode;
                        _count--;
                    }

                }
            }
            catch (Exception)
            {

                Console.WriteLine("Error");
            }
            
        }

        public int Count()
        {
            return _count;
        }

        public bool Contains(T item)
        {
            Node<T> temp = _first;

            while (temp != null)
            {
                if (temp.Data.Equals(item))
                    return true;

                temp = temp.NextNode;
            }

            return false;
        }

        public T[] ToArray()
        {
            T[] array = new T[_count];
            Node<T> currentNode = _first;
            for (int i = 0; currentNode != null; i++)
            {
                array[i] = currentNode.Data;
                currentNode = currentNode.NextNode;
            }
            return array;
        }

        public T this[int position]
        {
            get
            {
                Node<T> tempNode = _last;
                for (int i = 0; i < position; ++i)
                    tempNode = tempNode.NextNode;
                return tempNode.Data;
            }
        }
    }
}
