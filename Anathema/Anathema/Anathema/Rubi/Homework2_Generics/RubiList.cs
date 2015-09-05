using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Anathema.Generics;

namespace Anathema.Rubi.Homework2_Generics
{
    public class RubiList<T>:GRList<T>,IEnumerable<T>
    {
        private T[] _items = new T[10];
        
        private int _index = 0;
       
        
        public bool AddItem(T item, bool unique)
        {
            if (_index == _items.Length)
                MakeListBigger(_items);

            if (unique && !_items.Contains(item))
            {
                _items[_index] = item;
            }
            if (!unique)
            {
                _items[_index] = item;
            }
            return true;
        }

        public int Lenght(T[] _items)
        {
            return _items.Length;

        }

        public T[] MakeListBigger(T[] _items )
        {
           Array.Copy(this._items,_items,Lenght(_items)+1);
           return _items;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}