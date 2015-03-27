using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Base.Inheritance;
using Toci.TraininigLibrary.Developers.Chmura.Common;

namespace Toci.TraininigLibrary.Developers.Chmura.ChmuraInheritanceTask
{
    public class ChmuraStringDictionary<T> : StringDictionary<T>
    {
        public override List<T> GetAnagramSet(string anagramCandidate)
        {
            return (from d in this where d.Key.ChmuraIsAnagram(anagramCandidate) select d.Value).ToList();
        }

        public override List<T> GetPalindromSet()
        {
            return (from d in this where d.Key.ChmuraIsPalindrom() select d.Value).ToList();
        }

        public override List<T> GetWildcardSet(string wildcardCandidate)
        {
            return (from d in this where d.Key.ChmuraIsWildcard(wildcardCandidate) select d.Value).ToList();
        }
    }
}
