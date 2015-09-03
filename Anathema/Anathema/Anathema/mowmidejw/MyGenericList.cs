using System;
using System.Collections.Generic;

namespace Toci.Hornets.GenericListByMowmidejw
{
    public class MyGenericList<T>
    {
            private int _size;
            private readonly T[] _items;

        public MyGenericList()
        {
            _size = 0;
            _items = new T[10];
        }

        public T AddElement(T item)
        {
            _items[_size] = item;
            _size++;
            return item;
        }

        public bool AddElement(T item, int place)
        {
            if (place <= _size)
            {
                _items[place] = item;
                _size++;
            }
            else
            {
                Array.Copy(_items, new T[2*_size], 2*_size);
            }
            return true;
        }

        public bool Contains(T item)
        {
            bool contain = false;
                for(int i=0; i<=_items.Length;i++)
                if (EqualityComparer<T>.Default.Equals(_items[i], item))
                    contain = true;

            return contain;
        }

        public void Clear()
        {
            _size = 0;
            for(int i=0; i<=_items.Length;i++)
            {
                _items[i] = default(T);
            }
        }

        public bool DeleteItem(T item)
        {
            bool contain = false;
            for (int i = 0; i <= _items.Length; i++)
                if (EqualityComparer<T>.Default.Equals(_items[i], item))
                {
                    _items[i] = default(T);
                    contain = true;
                }

            return contain;
        }
    }
}