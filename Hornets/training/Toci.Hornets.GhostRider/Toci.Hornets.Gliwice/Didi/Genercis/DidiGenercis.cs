using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.TrainingFour.Generics;

namespace Toci.Hornets.Gliwice.Didi.Genercis
{
    public class DidiGenercis<Titem> : GhostRiderGenericList<Titem>
    {
       
        public override bool Add(Titem item)
        {
            return Add(item); 
        }

        public override bool Remove(Titem item)
        {
            return Remove(item); 
        }
    }
}
