using System;
using Toci.Hornets.Sieradz.Undergroun1Task.Interface;

namespace Toci.Hornets.Sieradz.UCantTouchThis.Underground1Task
{
    public class UCTT_AutismStringComparator : IStringComparator
    {
        public bool CompareTwoStrings(string str1, string str2)
        {
            int numberOfLettersInS1 = 0, numberOfLettersInS2 = 0;
            char[] s1 = str1.ToCharArray();
            char[] s2 = str2.ToCharArray();
            Int32 condition;

            foreach (char t in s1)
            {
                // Sonic my name
                condition = (~((t - 65) >> 31) & ((t - 90) >> 31)) |
                            (~((t - 97) >> 31) & ((t - 122) >> 31))  ;
                // speed is my game
                numberOfLettersInS1 += condition & 1;
            }

            foreach (char t in s2)
            {
                condition = (~((t - 65) >> 31) & ((t - 90) >> 31)) |
                            (~((t - 97) >> 31) & ((t - 122) >> 31));
                numberOfLettersInS2 += condition & 1;
            }

            return numberOfLettersInS1 == numberOfLettersInS2;
        }
    }
}