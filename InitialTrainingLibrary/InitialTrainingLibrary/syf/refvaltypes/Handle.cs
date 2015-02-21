using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.syf.refvaltypes
{
    class Handle
    {
        public virtual void ModifyIncomingRefTypeParameter(RefTypeExample example)
        {
            example.test += 5;
        }

        public void ModifyIncomingValTypeParameter(int test)
        {
            test += 5;
        }
    }
}
