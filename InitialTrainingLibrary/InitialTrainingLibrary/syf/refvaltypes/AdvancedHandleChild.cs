using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.syf.refvaltypes
{
    class AdvancedHandleChild : Handle
    {
        public override void ModifyIncomingRefTypeParameter(RefTypeExample example)
        {
            example.test += 10;
        }
    }
}
