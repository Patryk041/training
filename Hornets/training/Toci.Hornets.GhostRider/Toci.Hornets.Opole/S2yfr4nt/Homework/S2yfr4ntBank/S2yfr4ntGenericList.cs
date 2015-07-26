using System.Collections;
using System.Linq;
using Toci.Hornets.GhostRider.TrainingFour.Generics;

namespace Toci.Hornets.Opole.S2yfr4nt.Homework.S2yfr4ntBank
{
    public class S2yfr4ntGenericList<TItems>: GhostRiderGenericList<TItems>
    {

        public override bool Add(TItems item)
        {
            var list = items.ToList();
            list.Add(item);
            items = list.ToArray();
            return true;
        }

        public override bool Remove(TItems item)
        {
            var list = items.ToList();
            list.Remove(item);
            items = list.ToArray();
            return true;
        }
    }
}
