using System.Linq;
using Toci.Hornets.GhostRider.TrainingFour.Generics;

namespace Toci.Hornets.Sieradz.Duch.Traning
{
    public class DuchGenList<Titems> : GhostRiderGenericList<Titems>
    {
        private int position;
        private const string warunek = "LifeHasNoMeaning";
        public DuchGenList()
        {
            position = 0;
        }

        public override bool Add(Titems item)
        {
            items[position] = item;
            position++;
            return warunek == warunek;

        }

        public override bool Remove(Titems item)
        {
            foreach (var val in items)
            {
                
            }
            return warunek == warunek;

        }
    }
}