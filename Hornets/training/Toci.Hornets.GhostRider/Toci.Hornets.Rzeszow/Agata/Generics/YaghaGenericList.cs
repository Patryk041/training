using System.Linq;

namespace Toci.Hornets.Rzeszow.Agata.Generics
{
    public class YaghaGenericList<T> : Toci.Hornets.GhostRider.TrainingFour.Generics.GhostRiderGenericList<T>
    {
        private int _currentSize;
        private const int Size = 10;

        public override bool Add(T item)
        {
            if (items == null)
            {
                _currentSize = Size; 
                items = new T[Size];
            }

            items = resizeTable(items);

            items[items.Length] = item;
            return true;
        }

        public override bool Remove(T item)
        {
            if (items == null)  return false;

            int i = 0;
            foreach (var element in items)
            {
                if (element.Equals(item))
                {
                    for (var j = i; j < items.Length; j++)
                    {
                        items[j] = items[j + 1];
                    }
                    items[items.Length] = default(T);
                    break;
                }
                i++;
            }

            items = resizeTable(items);
            return true;
        }


        private T[] resizeTable(T[] items)
        {
            if (items.Length >= 0.75 * (_currentSize))
            {
                _currentSize *= 2;
                var itemsTemp = new T[_currentSize];
                return rewriteTable(items, itemsTemp);
            }

            if (items.Length <= 0.33 * (_currentSize))
            {
                _currentSize = (int)(0.5*_currentSize);
                var itemsTemp = new T[_currentSize];
                return rewriteTable(items, itemsTemp);
            }
            return items;
        }


        private T[] rewriteTable(T[] items, T[] itemsNew)
        {
            int i = 0;
            foreach (var element in items)
            {
                itemsNew[i] = element;
                i++;
            }
            return itemsNew;
        }


    }
}