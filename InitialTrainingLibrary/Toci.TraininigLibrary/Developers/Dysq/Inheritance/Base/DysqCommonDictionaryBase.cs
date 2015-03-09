using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Dysq.Inheritance.Interfaces;

namespace Toci.TraininigLibrary.Developers.Dysq.Inheritance.Base
{
    public abstract class DysqCommonDictionaryBase<T> : Dictionary<string, T>, IDysqCommonDictionaryBase<T>
    {
        public abstract List<T> GetAnagramSet(string anagramCandidate);

        public abstract List<T> GetPalindromSet();

        public abstract List<T> GetWildcardSet(string wildcard);

    }
}
