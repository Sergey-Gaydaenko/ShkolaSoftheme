using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    public class Node<TKey, TValue>
    {
        public TValue Value { get; set; }
        public TKey Key { get;  set; }

        public Node( TKey key,TValue value)
        {
            Value = value;
            Key = key;
        }
    }
}
