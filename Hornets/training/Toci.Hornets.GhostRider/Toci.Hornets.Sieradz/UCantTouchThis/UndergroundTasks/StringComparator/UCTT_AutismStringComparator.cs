using System.Runtime.CompilerServices;
using Toci.Hornets.Sieradz.Undergroun1Task.Interface;

namespace Toci.Hornets.Sieradz.UCantTouchThis.UndergroundTasks.StringComparator
{
    public class UCTT_AutismStringComparator : IStringComparator
    {
        private const int smallZ = 'z' + 1;
        private const int bigZ = 'Z' + 1;

        public bool CompareTwoStrings(string string1, string string2)
        {
            char[] s1 = string1.ToCharArray();
            char[] s2 = string2.ToCharArray();

            return CountLetters(s1) == CountLetters(s2);

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static int CountLetters(char[] array)
        {
            int numberOfLetters = 0;
            for (int i = 0; i < array.Length; i++)
            {
                numberOfLetters += ((~((array[i] - 'A') >> 31) & ((array[i] - bigZ) >> 31)) |
                  (~((array[i] - 'a') >> 31) & ((array[i] - smallZ) >> 31))) & 1;
            }
            return numberOfLetters;

        }

    }
}