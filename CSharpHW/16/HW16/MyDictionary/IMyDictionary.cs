using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    interface IMyDictionary<TKey, TValue>
    {
        void Add(TKey key, TValue value);
        void Remove(TKey key);
    }
}
