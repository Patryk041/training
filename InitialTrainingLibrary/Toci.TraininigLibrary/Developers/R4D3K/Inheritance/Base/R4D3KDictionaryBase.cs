using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.R4D3K.Inheritance.Interfaces;

namespace Toci.TraininigLibrary.Developers.R4D3K.Inheritance
{
    public abstract class R4D3KDictionaryBase<T> : Dictionary<string, T>, IR4D3KInterface<T>
    {
        public abstract List<T> GetAnagramSet(string anagramCandidate);

        public abstract List<T> GetPalindromSet();

        public abstract List<T> GetWildcardSet(string wildcard);
    }
}
