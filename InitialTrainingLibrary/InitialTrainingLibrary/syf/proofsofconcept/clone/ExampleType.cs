using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.syf.proofsofconcept.clone
{
    public class ExampleType : ICloneable
    {
        public int test = 2;
        public string test2 = "sdfaafa";

        public ExampleSubType subTypeField;

        public ExampleType()
        {
            subTypeField = new ExampleSubType();
        }

        public object Clone()
        {
            var newObj = (ExampleType)MemberwiseClone();
            newObj.subTypeField = (ExampleSubType)newObj.subTypeField.Clone();

            return newObj;
        }
    }
}
