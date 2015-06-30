using System;
using Toci.Hornets.Sieradz.Undergroun1Task.Interface;

namespace Toci.Hornets.Sieradz.UCantTouchThis.Underground1Task
{
    public class UCTT_AutismStringComparator : IStringComparator
    {
        public bool CompareTwoStrings(string string1, string string2)
        {
            int numberOfLettersInS1 = 0, numberOfLettersInS2 = 0;
            char[] s1 = string1.ToCharArray();
            char[] s2 = string2.ToCharArray();
            Int32 condition;

            for (int i = 0; i < s1.Length; ++i)
            {
                    // Sonic my name
                condition = (~((s1[i] - 'A') >> 31) & ((s1[i] - 'Z') >> 31)) |
                            (~((s1[i] - 'a') >> 31) & ((s1[i] - 'z') >> 31));
                    // speed is my game
                numberOfLettersInS1 += condition & 1;
            }

            for (int i = 0; i < s2.Length; ++i)
            {
                condition = ((~((s2[i] - 65) >> 31) & ((s2[i] - 90) >> 31)) |
                            (~((s2[i] - 97) >> 31) & ((s2[i] - 122) >> 31)));
                numberOfLettersInS2 += condition & 1;
            }

            return numberOfLettersInS1 == numberOfLettersInS2;
        }

    }
}