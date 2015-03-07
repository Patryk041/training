using System.Collections.Generic;
using System.Linq;
using Toci.TraininigLibrary.Common.Base.Inheritance;

namespace Toci.TraininigLibrary.Developers.RS.RSDictionary
{
    public class RsDictionary<T> : StringDictionary<T>
    {
        public override List<T> GetAnagramSet(string anagramCandidate)
        {
            List<T> results = new List<T>();

            foreach (var dictionaryMember in this)
            {
                var anagramCharArray = anagramCandidate.ToLower().ToCharArray().OrderBy(s => s);
                var dictionaryMemberKeyCharArray = dictionaryMember.Key.ToLower().ToCharArray().OrderBy(s => s);

                if (anagramCharArray.SequenceEqual(dictionaryMemberKeyCharArray))
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
                var key = dictionaryMember.Key.ToLower().ToCharArray();
                var reverseKey = key.Reverse();
                
                if (key.SequenceEqual(reverseKey))
                {
                    results.Add(dictionaryMember.Value);
                }
            }
            return results;
        }

        public override List<T> GetWildcardSet(string wildcard)
        {
            int wildcardSize = wildcard.Length;
            List<T> results = new List<T>();

            foreach (var dictionaryMember in this)
            {
                if (dictionaryMember.Key.Length < wildcardSize)
                {
                    continue;
                }

                string subStringKey = dictionaryMember.Key.Substring(0, wildcardSize);

                if (subStringKey == wildcard)
                {
                    results.Add(dictionaryMember.Value);
                }
            }
            return results;
        }
    }
}
