using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Base.Inheritance;
using Toci.TraininigLibrary.Developers.Robson.RobsonsDictionaryInheritance;

namespace Toci.TraininigLibrary.Developers.Robson.RobsonExtendedDictionary
{
    public static class RobsonsUtilityClass
    {
        public static List<string> GetAnagramList(this RobsonsDictionary dict, string anagramCandidate)
        {
            List<string> list = new List<string>();

            foreach (var item in dict)
            {
                var firstString = item.Key.ToArray().Where(c => c >= 'a' && c <= 'z');
                var secondString = anagramCandidate.ToArray().Where(c => c >= 'a' && c <= 'z');

                if (firstString.OrderBy(c => c).SequenceEqual(secondString.OrderBy(c => c)))
                {
                    list.Add(item.Key);
                }
            }
            return list;
        }

        public static List<string> GetPalindromsList(this RobsonsDictionary dict)
        {
            List<string> list = new List<string>();

            foreach (var item in dict)
            {
                string firstString = item.Key.ToString();
                StringBuilder secondString = new StringBuilder(firstString.Length);
                for (int i = firstString.Length - 1; i >= 0; i--)
                {
                    secondString.Append(firstString[i]);
                }

                if (firstString == secondString.ToString())
                {
                    list.Add(item.Key);
                }
            }
            return list;
        }

        public static List<string> GetWildcardList(this RobsonsDictionary dict, string wildcard)
        {
            List<string> list = new List<string>();

            foreach (var item in dict)
            {
                if (item.Key.ToString().StartsWith(wildcard))
                {
                    list.Add(item.Key);
                }
            }

            return list;
        }
    }
}
