using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Koziu.StringDictionary
{
    public static class LogicKoziuStringDictionary
    {
        public static bool IsAnagram(string key, string anagramCandidate)
        {
            return (key.OrderBy(x => x).SequenceEqual(anagramCandidate.ToLower().OrderBy(x => x)));

        }
        public static bool IsPalindrom(string key)
        {
            return key.ToLower().ToCharArray().SequenceEqual(key.ToLower().ToCharArray().Reverse());   
        }

        public static bool IsWildcard(string key, string wildcard)
        {
            int size = wildcard.Length;
            bool isWildcard = false;
            if(size <= key.Length)
            {
                for(int i = 0; i < size; i++)
                {
                    isWildcard = (wildcard.ToLower()[i] == key.ToLower()[i]) ? true : false;
                    if (!isWildcard) i = size;
                }
            }
            return isWildcard;
        }
    }
}
