using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.TrainingThree.Inheritance
{
    public abstract class WarriorDictionary<T> : Dictionary<string, T>
    {
        public abstract List<T> GetAnagramSet(string anagramCandidate); //radar  raadr

        public abstract List<T> GetPalindromSet(); // cyc radar aerrea

        public abstract List<T> GetWildcardSet(string wildcard); // test*  :   testdsafda testewqrfqe, testgfe
    }
}
