using Toci.Hornets.GhostRider.TrainingFour.Generics;

namespace Toci.Hornets.Opole.Lausion.TaskFour
{
    public class LausionGenericList<TItems> : GhostRiderGenericList<TItems>
    {
        public override bool Add(TItems item)
        {
            if (items != null)
            {
                items[items.Length] = item;
            }
            else
            {
                items=new TItems[]{item};
            }
            return true;
        }

        public override bool Remove(TItems item)
        {
            if (items == null)
                return false;
            else
            {
                for (int i = 0; i < items.Length; i++)
                {
                    if (items[i].Equals(item))
                    {
                        removeItem(items, i);
                        items[items.Length] = default(TItems);
                        return true;
                    }
                }
                return false;
            }
        }

        private static void removeItem(TItems[] items, int i)
        {
            for (int j = 0,x=0; j <items.Length; j++)
            {
                if (i == j) continue;
                items[x] = items[j];
                x++;
            }
        }
    }
}