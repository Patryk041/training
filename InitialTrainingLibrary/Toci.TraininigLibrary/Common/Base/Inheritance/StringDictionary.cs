using System;
using System.Collections.Generic;
using System.Linq;using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Common.Base.Inheritance
{
    public abstract class StringDictionary<T> : Dictionary<string, T>
    {
        public abstract List<T> GetAnagramSet(string anagramCandidate); //radar  raadr

        public abstract List<T> GetPalindromSet(); // cyc radar aerrea

        public abstract List<T> GetWildcardSet(string wildcard); // test*  :   testdsafda testewqrfqe, testgfe
    }
}
