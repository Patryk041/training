using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Base.Inheritance;

namespace Toci.TraininigLibrary.Developers.Koziu.StringDictionary
{
    public class KoziuStringDictionary<T> : StringDictionary<T>
    {

        public override List<T> GetAnagramSet(string anagramCandidate)
        {
            return (from entity in this where LogicKoziuStringDictionary.IsAnagram(entity.Key, anagramCandidate) select entity.Value).ToList();
        }

        public override List<T> GetPalindromSet()
        {
            return (from entity in this where LogicKoziuStringDictionary.IsPalindrom(entity.Key) select entity.Value).ToList();
        }

        public override List<T> GetWildcardSet(string wildcard)
        {
            return (from entity in this where LogicKoziuStringDictionary.IsWildcard(entity.Key, wildcard) select entity.Value).ToList();
        }
    }

    
}
