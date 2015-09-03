using System.Collections.Generic;
using System.Linq;
using Toci.Hornets.GhostRider.TrainingFour.Generics;

namespace Toci.Hornets.Rzeszow.SemiRafista.TrainingFour
{
    public class SeRaGenerics<TItem> : GhostRiderGenericList<TItem>
    {
        public override bool Add(TItem item)
        {
            if (item == null) return false;                         

            var tempTab = items == null ? new TItem[1] : new TItem[items.Length + 1];
            if (items == null)
            {
                tempTab[0] = item;
            }
            else
            {
                items.CopyTo(tempTab, 0);
                tempTab[items.Length] = item; 
            }

            items = tempTab;
            return true;
        }

        public override bool Remove(TItem item)
        {
            if (item == null || items == null || items.Contains(item) == false) return false;

            items = items.Where(element => element.Equals(item) == false).ToArray();
            return true;
        }
    }
}