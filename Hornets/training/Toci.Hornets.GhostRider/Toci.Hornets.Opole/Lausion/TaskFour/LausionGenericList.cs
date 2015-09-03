using Toci.Hornets.GhostRider.TrainingFour.Generics;

namespace Toci.Hornets.Opole.Lausion.TaskFour
{
    public class LausionGenericList<TItems> : GhostRiderGenericList<TItems>
    {
        private int size;
        private int maxSize;
        public LausionGenericList()
        {
            size=0;
            maxSize = 15;
            items=new TItems[maxSize];
        }
        public override bool Add(TItems item)
        {
            if (size <maxSize)//Jezeli nie jest pelna
            {
                items[size] = item;
                size++;
            }
            else//Jezeli pełna
            {
                maxSize = maxSize*2;
                var pom= items;
                items=new TItems[maxSize];
                for (int i = 0; i <pom.Length; i++)
                {
                    items[i] = pom[i];
                }

                Add(item);
            }
            return true;
        }

        public override bool Remove(TItems item)
        {
            if (items == null)
                return false;
            else
            {
                for (int i = 0; i <size; i++)
                {
                    if (items[i].Equals(item))
                    {
                        removeItem(items, i);
                        size--;
                        if (size < 0.3*maxSize)
                            resize();
                        return true;
                    }
                }
                return false;
            }
        }

        private void removeItem(TItems[] items, int i)
        {
            int length = size;
            size = 0;
            for (int j = 0; j <length+1; j++)
            {
                if (i == j) continue;
                items[size++] = items[j];
            }
        }

        private void resize()
        {
            var pom = items;
            maxSize = (int)(maxSize*0.7);
            items=new TItems[maxSize];
            for (int i = 0; i < size; i++)
            {
                items[i] = pom[i];
            }
        }
    }
}