using System.Linq;
using Toci.Hornets.GhostRider.TrainingFour.Generics;

namespace Toci.Hornets.Opole.S2yfr4nt.Homework.S2yfr4ntGenericList
{
    public class S2yfr4ntGenericList<TItems>: GhostRiderGenericList<TItems>
    {
        public override bool Add(TItems item)
        {
            if(items.Length == 0)
                items = new[]{item};
            else
            {
                TItems[] array = new TItems[items.Length];
                for (int i = 0; i < items.Length-1; i++)
                {
                    array[i] = items[i];
                }
                array[array.Length] = item;
                items = array;
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
                if (!items[i].Equals(item))
                {
                    RemoveItem(i);
                    return true;
                }
            }
            return false;
        }
        public void RemoveItem(int indexOfItem)
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
            items = array;

        }
    }
}