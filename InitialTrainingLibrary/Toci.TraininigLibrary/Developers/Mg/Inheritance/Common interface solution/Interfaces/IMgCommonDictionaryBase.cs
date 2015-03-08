using System.Collections;
using System.Collections.Generic;

namespace Toci.TraininigLibrary.Developers.Mg.Inheritance.Common_interface_solution.Interfaces
{
    public interface IMgCommonDictionaryBase<T> : IDictionary//: IDictionary<string, T>
   {
        List<T> GetAnagramSet(string anagramCandidate); //radar  raadr
        List<T> GetPalindromSet(); // cyc radar aerrea
        List<T> GetWildcardSet(string wildcard); // test*  :   testdsafda testewqrfqe, testgfe
    }
}
