using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.R4D3K.Inheritance.Interfaces
{
    public interface IR4D3KInterface<T>
    {
        List<T> GetAnagramSet(string anagramCandidate); //radar  raadr

        List<T> GetPalindromSet(); // cyc radar aerrea

        List<T> GetWildcardSet(string wildcard); // test*  :   testdsafda testewqrfqe,
    }
}
