using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.syf.proofsofconcept.clone
{
    public class ExampleTypeUsage
    {
        private void DoOperations(ExampleType type)
        {
            type.test = 10;
            type.subTypeField.test = "text po zmianach";
        }

        public void TestClone()
        {
            var example = new ExampleType();

            DoOperations(example);

            int tst = example.test;

            var clone = (ExampleType) example.Clone();

            DoOperations(clone);

            clone.subTypeField.test = "zmiana w klonie";
            clone.test = 50;

            string test2 = example.subTypeField.test;
        }
    }
}
