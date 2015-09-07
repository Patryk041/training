using System;
using System.Linq;
using Anathema.Generics;

namespace Anathema.wojtek
{
    public class WojteksGenericList<T>  : GRList<T>
    {
         private T [] _items = new T[10];
         private int _index;

        public override bool AddElement(T item, bool unique = true)
        {
            if (unique)
            {
                if (_items.Contains(item))
                    return false;
            }
            if (_index == _items.Length)
                _items=ExpandArray((_items));
            _items[_index] = item;
            _index++;
            return true;
        }

        private T[] ExpandArray(T[] array)
        {
            T[] temporaryArray = new T[_index * 2];
            Array.Copy(array, temporaryArray, _index * 2);
            array = temporaryArray;
            return array;
        }
    }
}