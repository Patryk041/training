using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.Rhonin.Words
{
    /// <summary>
    /// Text Utils.
    /// Version 0.1
    /// </summary>
    public static class TextUtils
    {
        public static bool IsPalindrom(string candidate)
        {
            string candidate2 = new string(candidate.ToCharArray().Reverse().ToArray());
            return candidate == candidate2 ? true : false;
        }

        public static bool IsAnagram(string candidate, string candidate2)
        {
            List<char> can1 = candidate.ToList();
            List<char> can2 = candidate2.ToList();
            can1.Sort();
            can2.Sort();
            return can2.SequenceEqual(can1);
        }

        public static bool IsWildCard(string candidate,string wildcard)
        {
            return candidate.StartsWith(wildcard);
        }
    }
}
