using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Base.Inheritance;

namespace Toci.TraininigLibrary.Developers.Vernathic.Inheritance
{
    public class VInheritance<T> : StringDictionary<T>
    {      
        public override List<T> GetAnagramSet(string anagramCandidate)    //radar  raadr
        {
            throw new NotImplementedException();
        }

        public override List<T> GetPalindromSet()           // cyc radar aerrea
        {
            throw new NotImplementedException();
        }

        public override List<T> GetWildcardSet(string wildcard)     // test*  :   testdsafda testewqrfqe, testgfe
        {
            throw new NotImplementedException();
        }
    }
}
