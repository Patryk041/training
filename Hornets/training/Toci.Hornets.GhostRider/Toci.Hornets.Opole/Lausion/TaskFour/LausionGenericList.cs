using Toci.Hornets.GhostRider.TrainingFour.Generics;

namespace Toci.Hornets.Opole.Lausion.TaskFour
{
    public class LausionGenericList<TItems> : GhostRiderGenericList<TItems>
    {
        private int cap;
        private int maxCap;
        public LausionGenericList()
        {
            cap=0;
            maxCap = 50;
            items=new TItems[50];
        }
        public override bool Add(TItems item)
        {
            if (cap <maxCap)
            {
                items[cap] = item;
                cap++;
            }
            else
            {
                maxCap = maxCap*5;
                var pom= items;
                items=new TItems[maxCap];
                for (int i = 0; i < cap; i++)
                {
                    
                }
            }
            return true;
        }

        public override bool Remove(TItems item)
        {
            if (items == null)
                return false;
            else
            {
                for (int i = 0; i < cap; i++)
                {
                    if (items[i].Equals(item))
                    {
                        removeItem(items, i);
                        items[cap] = default(TItems);
                        cap--;
                        return true;
                    }
                }
                return false;
            }
        }

        private void removeItem(TItems[] items, int i)
        {
            for (int j = 0,x=0; j <cap; j++)
            {
                if (i == j) continue;
                items[x] = items[j];
                x++;
            }
        }
    }
}