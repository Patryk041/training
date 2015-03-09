using System.Collections.Generic;
using System.Linq;
using Toci.TraininigLibrary.Common.RsStaticClasses;

namespace Toci.TraininigLibrary.Developers.RS.RSDictionary
{
    public class RsHashtable<T> : RsHashtableBase<T> where T : class
    {
        public override List<T> GetAnagramSet(string anagramCandidate)
        {
            List<T> results = new List<T>();

            foreach (var hashtableMember in Keys)
            {
//                var anagramCharArray = anagramCandidate.ToLower().ToCharArray().OrderBy(s => s);
//                var dictionaryMemberKeyCharArray = hashtableMember.ToString().ToLower().ToCharArray().OrderBy(s => s);
//
//                if (anagramCharArray.SequenceEqual(dictionaryMemberKeyCharArray))
//                {
//                    results.Add(this[hashtableMember] as T);
//                }

                if (RsDictionaryHelpers.IsAnagram(anagramCandidate, hashtableMember.ToString()))
                {
                    results.Add(this[hashtableMember] as T);
                }
            }
            return results;
        }

        public override List<T> GetPalindromSet()
        {
            List<T> results = new List<T>();

            foreach (var hashtableMember in Keys)
            {
//                var key = hashtableMember.ToString().ToLower().ToCharArray();
//                var reverseKey = key.Reverse();
//
//                if (key.SequenceEqual(reverseKey))
//                {
//                    results.Add(this[hashtableMember] as T);
//                }

                if (RsDictionaryHelpers.IsPalindrom(hashtableMember.ToString()))
                {
                    results.Add(this[hashtableMember] as T);
                }
            }
            return results;
        }

        public override List<T> GetWildcardSet(string wildcard)
        {
            int wildcardSize = wildcard.Length;
            List<T> results = new List<T>();

            foreach (var hashtableMember in Keys)
            {
//                if (hashtableMember.ToString().Length < wildcardSize)
//                {
//                    continue;
//                }
//
//                string subStringKey = hashtableMember.ToString().Substring(0, wildcardSize);
//
//                if (subStringKey == wildcard)
//                {
//                    results.Add(this[hashtableMember] as T);
//                }

                if (RsDictionaryHelpers.ContainsWildCard(wildcard, hashtableMember.ToString()))
                {
                    results.Add(this[hashtableMember] as T);
                }
            }
            return results;
        }
    }
}
