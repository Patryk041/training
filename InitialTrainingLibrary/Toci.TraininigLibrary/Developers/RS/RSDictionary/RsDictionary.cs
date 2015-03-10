using System.Collections.Generic;
using System.Linq;
using Toci.TraininigLibrary.Common.Base.Inheritance;
using Toci.TraininigLibrary.Common.RsStaticClasses;

namespace Toci.TraininigLibrary.Developers.RS.RSDictionary
{
    public class RsDictionary<T> : StringDictionary<T>
    {
        public override List<T> GetAnagramSet(string anagramCandidate)
        {
            // OLD VERSION
//            List<T> results = new List<T>();
//
//            foreach (var dictionaryMember in this)
//            {
//                if (RsDictionaryHelpers.IsAnagram(anagramCandidate, dictionaryMember.Key))
//                {
//                    results.Add(dictionaryMember.Value);
//                }
//            }
//            return results;

            // NEW VERSION
            var results = RsDictionaryHelpers.RsDictionaryHelperInvoke(RsDictionaryHelpers.IsAnagram, this, anagramCandidate).ToList();
            return results.Cast<T>().ToList();
        }

        public override List<T> GetPalindromSet()
        {
            // OLD VERSION
//            List<T> results = new List<T>();
//
//            foreach (var dictionaryMember in this)
//            {
//                if (RsDictionaryHelpers.IsAnagram(null, dictionaryMember.Key))
//                {
//                    results.Add(dictionaryMember.Value);
//                }
//            }
//            return results;

            // NEW VERSION
            var results = RsDictionaryHelpers.RsDictionaryHelperInvoke(RsDictionaryHelpers.IsPalindrom, this, null).ToList();
            return results.Cast<T>().ToList();
        }

        public override List<T> GetWildcardSet(string wildcard)
        {
            // OLD VERSION
//            List<T> results = new List<T>();
//
//            foreach (var dictionaryMember in this)
//            {
//                if (RsDictionaryHelpers.IsAnagram(wildcard, dictionaryMember.Key))
//                {
//                    results.Add(dictionaryMember.Value);
//                }
//            }
//            return results;

            // NEW VERSION
            var results = RsDictionaryHelpers.RsDictionaryHelperInvoke(RsDictionaryHelpers.ContainsWildCard, this, wildcard).ToList();
            return results.Cast<T>().ToList();
        }
    }
}
