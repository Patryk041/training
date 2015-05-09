using System;

namespace InitialTrainingLibrary.Zielu.Extensions
{
    public static class IntExtensions
    {
        public static bool IsEven(this int number)
        {
            return number%2 == 0;
        }

        public static bool IsOdd(this int number)
        {
            return number%2 != 0;
        }

        public static int Distance(this int a, int b)
        {
            return Math.Abs(a - b);
        }
    }
}
