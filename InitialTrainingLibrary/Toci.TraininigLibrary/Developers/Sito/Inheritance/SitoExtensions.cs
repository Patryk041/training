using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Sito.Inheritance
{
    public static class SitoExtensions
    {
        public static List<T> SitoGetPalindromSet<T>(this Dictionary<string,T> dictionary)
        {
            return (from item in dictionary where item.Key.ToCharArray().SequenceEqual(item.Key.ToCharArray().Reverse()) select item.Value).ToList();
        }

        public static List<T> SitoGetWildcardSet<T>(this Dictionary<string, T> dictionary,string wildCard)
        {
            return (from item in dictionary where item.Key.StartsWith(wildCard) select item.Value).ToList();
        }
        public static List<T> SitoGetAnagramSet<T>(this Dictionary<string, T> dictionary, string anagramCandidate)
        {
            return (from item in dictionary where item.Key.ToCharArray().OrderBy(c => c).SequenceEqual(anagramCandidate.ToCharArray().OrderBy(c => c)) select item.Value).ToList();
        }
    }
}
