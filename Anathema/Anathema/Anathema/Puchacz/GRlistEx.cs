using System;

namespace Anathema.Puchacz
{
    public class GrListEx<T>
    {
        private T[] _items = new T[3];
        private int _index;

        public virtual bool AddElement(T item, bool unique = true)
        {
            foreach (var i in _items)
            {
                if (i.Equals(item))
                {
                    return false;
                }
            }

            if (_index < _items.Length)
            {
                _items[_index] = item;
                _index++;
                return true;
            }

            if (_index >= _items.Length)
            {
                _items = ArrayEnlargeTwice(_items);
                _items[_index] = item;
                _index++;
                return true;
            }

            return false;
        }

        public virtual T[] ArrayEnlargeTwice(T[] inputArray)
        {
            var outputArray = new T[inputArray.Length * 2];
            Array.Copy(inputArray, outputArray, (inputArray.Length));
            return outputArray;
        }
    }
}
