using System.Drawing.Design;
using Toci.Hornets.GhostRider.TrainingFour.Generics;
using Toci.Hornets.Sieradz.Duch.Traning;

namespace Toci.Hornets.Sieradz.TypowyAdam.GenericListTaskTrainingFour
{
    public class TypowyAdamGenericList<TItems> : GhostRiderGenericList<TItems>
        {

            public override bool Add(TItems item)
            {
                DuchGenListUtil<TItems>.ListMagic(items, ListEnum.Add, item);
                return true;
            }

            public override bool Remove(TItems item)
            {
                DuchGenListUtil<TItems>.ListMagic(items, ListEnum.Remove, item);
                return true;
            }
    }
}