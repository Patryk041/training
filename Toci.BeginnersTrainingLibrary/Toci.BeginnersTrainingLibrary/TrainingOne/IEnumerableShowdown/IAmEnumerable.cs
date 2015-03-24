using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.IEnumerableShowdown
{
    public class IAmEnumerable : IEnumerable
    {
        protected TypeEnumerator enumerator = new TypeEnumerator();

        public IEnumerator GetEnumerator()
        {
            return enumerator;
        }
    }
}
