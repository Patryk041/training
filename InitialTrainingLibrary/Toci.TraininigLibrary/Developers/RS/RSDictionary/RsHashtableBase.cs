using System.Collections;
using System.Collections.Generic;

namespace Toci.TraininigLibrary.Developers.RS.RSDictionary
{
    public abstract class RsHashtableBase<T> : Hashtable
    {
        public abstract List<T> GetAnagramSet(string anagramCandidate); //radar  raadr

        public abstract List<T> GetPalindromSet(); // cyc radar aerrea

        public abstract List<T> GetWildcardSet(string wildcard); // test*  :   testdsafda testewqrfqe, testgfe
    }
}
