using System.Linq;
using Toci.Hornets.GhostRider.TrainingFour.Generics;

namespace Toci.Hornets.Rzeszow.Chojnecki.trainingFour
{
    public class AndrzejGen<TItem> : GhostRiderGenericList<TItem>
    {
        public override bool Add(TItem item)
        {
            var tempTable = items == null ? new TItem[1] : new TItem[items.Length + 1];
            if (items == null) tempTable.SetValue(item, 0);
            else
            {
                items.CopyTo(tempTable, 0);
                tempTable.SetValue(item, items.Length);
            }
            items = tempTable;
            return true;
        }

        public override bool Remove(TItem item)
        {
            if (!items.Contains(item)) return false;
            var tempTable = new TItem[items.Length - 1];
            var u = 0;
            foreach (var i in items.Where(i => item.Equals(i) == false))
            {
                tempTable[u] = i;
                u += 1;
            }
            items = tempTable;
            return true;
        }
    }
}