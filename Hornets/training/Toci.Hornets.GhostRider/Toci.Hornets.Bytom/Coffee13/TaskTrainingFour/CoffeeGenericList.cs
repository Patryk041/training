using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.TrainingFour.Generics;

namespace Toci.Hornets.Bytom.Coffee13.TaskTrainingFour
{
    class CoffeeGenericList<TItems> : GhostRiderGenericList<TItems>
    {
        public override bool Add(TItems item)
        {
            throw new NotImplementedException();
        }

        public override bool Remove(TItems item)
        {
            throw new NotImplementedException();
        }
    }
}
