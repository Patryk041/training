using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.syf.proofsofconcept.clone
{
    public class ExampleSubType : ICloneable
    {
        public string test = "fsdafd";

        public int test2 = 4;

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
