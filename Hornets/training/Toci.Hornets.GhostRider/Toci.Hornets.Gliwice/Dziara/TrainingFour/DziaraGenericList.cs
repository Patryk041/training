using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.TrainingFour.Generics;

namespace Toci.Hornets.Gliwice.Dziara.TrainingFour
{
    public class DziaraGenericList<TItems> : GhostRiderGenericList<TItems>
    {
        public override bool Add(TItems item)
        {
            return this.Add(item);
        }

        public override bool Remove(TItems item)
        {
            return this.Remove(item);
        }
    }
}
