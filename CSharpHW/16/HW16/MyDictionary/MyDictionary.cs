using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    public class MyDictionary<TKey, TValue>: IMyDictionary<TKey,TValue>
    {
        public static List<Node<TKey,TValue>> list = new List<Node<TKey, TValue>>();

        public void Add(TKey key, TValue value)
        {
            if (ContainsKey(key))
            {
                Console.WriteLine("Cannot add element with same Key");
            }
            else
            {
                var node = new Node<TKey, TValue>(key, value);
                list.Add(node);
            }
        }

        public bool ContainsValue(TValue value)
        {
            if (value != null)
            {
                foreach (var item in list)
                {
                    if (item.Value.Equals(value))
                        return true;
                }
            }
            return false;
        }
        public bool ContainsKey(TKey key)
        {
            if (key == null)
            {
                throw new NullReferenceException();
            }
            foreach (var item in list)
            {
                if (item.Key.Equals(key))
                {
                    return true;
                }
            }
            return false;
        }
        public void Remove(TKey key)
        {
            if (key != null)
            {
                foreach (var item in list)
                {
                    if (item.Key.Equals(key))
                    {
                        list.Remove(item);
                        break;
                    }
                }
            }
        }
    }
}
