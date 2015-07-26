using System.Linq;
using Toci.Hornets.GhostRider.TrainingFour.Generics;

namespace Toci.Hornets.Opole.S2yfr4nt.Homework.S2yfr4ntGenericList
{
    public class S2yfr4ntGenericList<TItems>: GhostRiderGenericList<TItems>
    {
        private bool IsArrayEmpty = true;

        public override bool Add(TItems item)
        {
            if (IsArrayEmpty)
            {
                items = new[] {item};
                IsArrayEmpty = false;
            }
            else
            {
                TItems[] array = new TItems[items.Length + 1];
                for (int i = 0; i < items.Length; i++)
                {
                    array[i] = items[i];
                }

                array[array.Length - 1] = item;
                items = new TItems[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    items[i] = array[i];
                }
            }

            return true;
        }

        public override bool Remove(TItems item)
        {
            if (items.Length == 0)
                return false;
           // TItems[] array = new TItems[items.Length-1];
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Equals(item))
                {
                    RemoveItem(i);
                    return true;
                }
            }
            return false;
        }
        private void RemoveItem(int indexOfItem)
        {
            TItems[] array = new TItems[items.Length - 1];
            for (int i = 0, j=0; i < items.Length; i++, j++)
            {
                if (i != indexOfItem)
                {
                    array[j] = items[i];
                }
                else j--;
            }
            items = new TItems[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                items[i] = array[i];
            }

        }
    }
}