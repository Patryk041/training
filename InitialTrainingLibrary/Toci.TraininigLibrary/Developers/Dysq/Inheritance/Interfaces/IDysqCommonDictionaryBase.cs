using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Dysq.Inheritance.Interfaces
{
    public interface IDysqCommonDictionaryBase<T> : IDictionary
    {
        List<T> GetAnagramSet(string anagramCandidate); //radar  raadr
        List<T> GetPalindromSet(); // cyc radar aerrea
        List<T> GetWildcardSet(string wildcard); // test*  :   testdsafda testewqrfqe, testgfe
    }
}
