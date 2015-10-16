using System;
using System.Linq;
using Anathema.Generics;
namespace Anathema.Rhonin.TheFirstOne
{
    /**
        Generic list extending GRList.
        @version 1.0
    */
    public class GRListExtendend<T> : GRList<T>
    {
        private T[] _items = new T[5];
        private int _index = 0;
        /**
            Method that add a new element to the list.
            @param item Any object/variable to add.
            @param unique It must be unique or not in this list (default true for unique)
            @return bool true/false Its added or not.
        */
        public override bool AddElement(T item, bool unique = true)
        {
            if (unique == true)
            {
                if (_items.Contains(item))
                {
                    return false;
                }
            }
            if (_index + 1 >= _items.Length)
            {
                Array.Resize(ref _items,_index*2);
                _items[_index] = item;
                _index++;

            }
            return true;
        }
    }
}