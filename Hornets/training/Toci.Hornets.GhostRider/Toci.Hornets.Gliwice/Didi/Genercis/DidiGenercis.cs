using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.TrainingFour.Generics;

namespace Toci.Hornets.Gliwice.Didi.Genercis
{
    public class DidiGenercis : GhostRiderGenericList<int>
    {
        public override bool Add(int item)
        {
          return Add(item);  
        }

        public override bool Remove(int item)
        {
            return Remove(item); 
        }
    }
}
