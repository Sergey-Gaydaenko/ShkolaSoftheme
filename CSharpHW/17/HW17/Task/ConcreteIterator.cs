﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class ConcreteIterator<T> : Iterator<T>
    {
        private readonly ConcreteAggregate<T> _aggregate;
        private int _current;

        public ConcreteIterator(ConcreteAggregate<T> aggregate)
        {
            _aggregate = aggregate;
        }

        public override T First()
        {
            return _aggregate[0];
        }

        public override T Next()
        {
            T ret = default(T);

            if (_current++ < _aggregate.Count)
            {
                ret = _aggregate[_current-1];
            }

            return ret;
        }

        public override T CurrentItem()
        {
            return _aggregate[_current];
        }

        public override bool IsDone()
        {
            return _current >= _aggregate.Count;
        }
    }
}
