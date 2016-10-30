using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class ArrWrapper<T>
    {
        int _size;
        T[] _arr;

        public ArrWrapper()
        {
            _arr = new T[0];
        }

        public void Add(T item)
        {
            T[] temp = new T[_size + 1];
            for (int i = 0; i < _size-1; i++)
            {
                temp[i] = _arr[i];
            }
            temp[_size] = item;
            _arr = temp;
            _size = _size + 1;
        }

        public T GetByIndex(int index)
        {
            if (index > _size)
            {
                Console.WriteLine("Incorrect index!");
                return default(T);
            }
            return _arr[index]; ;
        }

        public bool Contains(T item)
        {
            foreach (var i in _arr)
            {
                if (i.ToString() == item.ToString())
                    return true;
            }
            return false;
        }
    }
}
