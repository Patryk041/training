using System.Linq;

namespace Toci.Hornets.Rzeszow.Agata.Generics
{
    public class YaghaGenericList<T> : Toci.Hornets.GhostRider.TrainingFour.Generics.GhostRiderGenericList<T>
    {
        private int currentSize, size = 10;

        public override bool Add(T item)
        {
            if (items == null)
            {
                currentSize = size; 
                items = new T[size];
            }
            if (items.Length == currentSize)
            {
                currentSize += 10;
                items = resizeTable(items);
            }

            items[items.Length] = item;
            return true;
        }

        public override bool Remove(T item)
        {
            int counter = items.TakeWhile(arrayItem => !Equals(arrayItem, item)).Count();

            items[counter] = default(T);

            items = (T[]) items.Where(x => !x.Equals(null));
            return true;
        }

        private T[] resizeTable(T[] items)
        {
            T[] itemsTemp = new T[currentSize];
            itemsTemp = items;
            return itemsTemp;
        }
    }
}