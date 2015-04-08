using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.S2yfr4nt.Text
{
    class S2yfr4ntTextUtils
    {
        public static bool IsPalindrom(string text)
        {
            return text.SequenceEqual(text.Reverse());
        }

        public static bool IsAnagram(string text, string anagram)
        {
            return text.OrderBy(c => c).SequenceEqual(anagram.OrderBy(c => c));
        }

        public static bool IsWildCard(string text, string wildcard)
        {
            return text.StartsWith(wildcard);
        }
    }
}
