using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.IEnumerableShowdown
{
    public class TypeEnumerator : IEnumerator
    {
        private string[] test = new[] {"zaba", "zly", "senator", "embrion", "niemaksywy"};
        private int index = 0;

        public bool MoveNext()
        {
            index++;
            if (index > test.Length - 1)
            {
                return false;
            }
            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public object Current {
            get
            {
                return test[index];
            }

            private set
            {
                test[index] = (string)value;
            }
        }
    }
}
