using Toci.Hornets.GhostRider.TrainingFour.Generics;
using Toci.Hornets.Sieradz.Duch.Traning;

namespace Toci.Hornets.Sieradz.UCantTouchThis.TrainingFour
{
    public class UCantTouchThisTraingFour<TItems> : GhostRiderGenericList<TItems>
    {
        public override bool Add(TItems item)
        {
            items = DuchGenListUtil<TItems>.ListMagic(items, ListEnum.Add, item);
            return true;
        }

        public override bool Remove(TItems item)
        {
            items = DuchGenListUtil<TItems>.ListMagic(items, ListEnum.Remove, item);
            return true;
        }
    }
}