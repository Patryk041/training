using System.Collections.Generic;
using Toci.TraininigLibrary.Common.Base.Inheritance;
using Toci.TraininigLibrary.Common.RsStaticClasses;

namespace Toci.TraininigLibrary.Developers.RS.RSDictionary
{
    public class RsDictionary<T> : StringDictionary<T>
    {
        public override List<T> GetAnagramSet(string anagramCandidate)
        {
            List<T> results = new List<T>();

            foreach (var dictionaryMember in this)
            {
                if (RsDictionaryHelpers.IsAnagram(anagramCandidate, dictionaryMember.Key))
                {
                    results.Add(dictionaryMember.Value);
                }
            }
            return results;
        }

        public override List<T> GetPalindromSet()
        {
            List<T> results = new List<T>();

            foreach (var dictionaryMember in this)
            {
                if (RsDictionaryHelpers.IsPalindrom(dictionaryMember.Key))
                {
                    results.Add(dictionaryMember.Value);
                }
            }
            return results;
        }

        public override List<T> GetWildcardSet(string wildcard)
        {
            List<T> results = new List<T>();

            foreach (var dictionaryMember in this)
            {
                if (RsDictionaryHelpers.ContainsWildCard(wildcard, dictionaryMember.Key))
                {
                    results.Add(dictionaryMember.Value);
                }
            }
            return results;
        }
    }
}
