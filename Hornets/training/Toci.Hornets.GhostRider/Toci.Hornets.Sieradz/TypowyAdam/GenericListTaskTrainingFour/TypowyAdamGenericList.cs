using System.Drawing.Design;
using System.Linq;
using Toci.Hornets.GhostRider.TrainingFour.Generics;
using Toci.Hornets.Sieradz.Duch.Traning;

namespace Toci.Hornets.Sieradz.TypowyAdam.GenericListTaskTrainingFour
{
    public class TypowyAdamGenericList<TItems> : GhostRiderGenericList<TItems>
        {

            public override bool Add(TItems item)
            {
                TItems[] newItems = new TItems[items.Length + 1];
                for(int i = 0; i<items.Length-1;i++)
                {
                    newItems[i] = items[i];
                }
                newItems[newItems.Length - 1] = item;
                return items.Count() == 0 ? false : true;
            }

            public override bool Remove(TItems item)
            {
               /* TItems[] newItems = new TItems[items.Length-1];
                for (int i = 0; i < newItems.Length - 1; i++)
                {
                    if (items[i] == item)
                    {
                        
                    }
                }*/
                return true;
            }
    }
}