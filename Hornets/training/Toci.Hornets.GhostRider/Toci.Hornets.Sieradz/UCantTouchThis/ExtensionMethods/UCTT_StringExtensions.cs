using System;

namespace Toci.Hornets.Sieradz.UCantTouchThis.ExtensionMethods
{
    public static class UCTT_StringExtensions
    {
        private const int ZeroAsciiValue = '0';
        public static string TryRemove(this string subject, string stringToDelete)
        {
            if (subject.Contains(stringToDelete))
                return subject.Remove(subject.IndexOf(stringToDelete, StringComparison.Ordinal), stringToDelete.Length);
            return subject;
        }

        public static int TryToGetNumber(this string stringWithNumber, int startIndex, int endIndex)
        {
            if (!AreIndexesOk(startIndex, endIndex)) return 0;
            if (stringWithNumber != null && stringWithNumber.Length > endIndex)
                return GetNumber(stringWithNumber, startIndex, endIndex);
            return 0;
        }

        private static bool AreIndexesOk(int startIndex, int endIndex)
        {
            return !(startIndex < 0 || startIndex > endIndex);
        }

        public static int GetNumber(string stringWithNumber, int startIndex, int endIndex)
        {
            int number = 0;
            for (int i = startIndex; i <= endIndex; i++)
                number = GetNextleValue(stringWithNumber[i], number);
            return number;
        }

        private static int GetNextleValue(char letter, int number)
        {
            return number*10 + (letter - ZeroAsciiValue);
        }
    }
}