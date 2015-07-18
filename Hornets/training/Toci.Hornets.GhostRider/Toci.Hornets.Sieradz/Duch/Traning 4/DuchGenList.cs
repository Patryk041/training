using Toci.Hornets.GhostRider.TrainingFour.Generics;

namespace Toci.Hornets.Sieradz.Duch.Traning
{
    public class DuchGenList<Titems> : GhostRiderGenericList<Titems>
    {
        public override bool Add(Titems item)
        {
            DuchGenListUtil<Titems>.ListMagic(items, ListEnum.Add, item);
            return true;
        }

        public override bool Remove(Titems item)
        {
            DuchGenListUtil<Titems>.ListMagic(items, ListEnum.Remove, item);
            return true;

        }
    }
}