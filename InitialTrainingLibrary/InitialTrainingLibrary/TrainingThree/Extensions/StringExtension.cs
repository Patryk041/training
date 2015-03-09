using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.TrainingThree.Extensions
{
    public static class StringExtension
    {
        public static bool IsPalindrom(this string s)
        {
            return s.Reverse().ToString() == s;
        }

        public static bool IsAnagram(this string s, string anagramCandidate)
        {
            return true;
        }

        public static List<T> GetPalindromSet<T>(this Dictionary<string, T> slownik)
        {
            return null;
        }

        public static string ShowFail(this ExtensionsFail fail)
        {

            //this.NickName = "eqwfq";

            return fail.NickName;
        }
    }
}
