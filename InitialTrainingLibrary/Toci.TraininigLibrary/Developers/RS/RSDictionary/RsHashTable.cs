using System.Collections.Generic;
using System.Linq;
using Toci.TraininigLibrary.Common.RsStaticClasses;

namespace Toci.TraininigLibrary.Developers.RS.RSDictionary
{
    public class RsHashtable<T> : RsHashtableBase<T> where T : class
    {
        public override List<T> GetAnagramSet(string anagramCandidate)
        {
            // OLD VERSION
//            List<T> results = new List<T>();
//
//            foreach (var hashtableMember in Keys)
//            {
//                if (RsDictionaryHelpers.IsAnagram(anagramCandidate, hashtableMember.ToString()))
//                {
//                    results.Add(this[hashtableMember] as T);
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
//            foreach (var hashtableMember in Keys)
//            {
//                if (RsDictionaryHelpers.IsPalindrom(null, hashtableMember.ToString()))
//                {
//                    results.Add(this[hashtableMember] as T);
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
//            foreach (var hashtableMember in Keys)
//            {
//                if (RsDictionaryHelpers.ContainsWildCard(wildcard, hashtableMember.ToString()))
//                {
//                    results.Add(this[hashtableMember] as T);
//                }
//            }
//            return results;

            // NEW VERSION
            var results = RsDictionaryHelpers.RsDictionaryHelperInvoke(RsDictionaryHelpers.ContainsWildCard, this, wildcard).ToList();
            return results.Cast<T>().ToList();
        }
    }
}
