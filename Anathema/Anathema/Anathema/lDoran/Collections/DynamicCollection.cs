using System;
using System.Collections;
using System.Collections.Generic;

namespace Anathema.lDoran.Collections
{
    public class DynamicCollection<T> : IEnumerable<T>
    {
        private T[] _collection;
        private int _index = 0;

        public DynamicCollection() : this(10)
        {
        }

        public DynamicCollection(int length)
        {
            _collection = new T[length];
        }

        public virtual void Add(T item)
        {
            if (_index >= _collection.Length)
            {
                resizeCollection();
            }

            _collection[_index] = item;
            _index++;
        }

        public int Length()
        {
            return _collection.Length;
        }

        public IEnumerator<T> GetEnumerator()
        {            
            return ((IEnumerable<T>)_collection).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void resizeCollection()
        {
            Array.Resize(ref _collection, _collection.Length + 1);
        }
    }
}
