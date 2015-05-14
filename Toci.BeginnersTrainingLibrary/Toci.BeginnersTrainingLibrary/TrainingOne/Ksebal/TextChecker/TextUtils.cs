using System;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Ksebal.TextChecker
{
    public static class TextUtils

    {
        public static string ReverseString(string text)
        {
            char[] arrayString = text.ToCharArray();

            Array.Reverse(arrayString);
            return new String(arrayString);
        }

        public static bool IsPalindrom(string text)
        {   
            return text == ReverseString(text);
        }

        public static bool IsAnagram(string text, string text2)
        {


            char[] arrayString = text.ToCharArray();
            char[] arrayString2 = text2.ToCharArray();
            Array.Sort(arrayString);
            Array.Sort(arrayString2);
            Console.WriteLine(arrayString.Length);
            for (int i = 0; i < arrayString.Length; i++)
                if (arrayString[i] != arrayString2[i])
                    return false;
            return true;
        }

        public static bool IsWildCard(string text, string text2)
        {


            char[] arrayString = text.ToCharArray();
            char[] arrayString2 = text2.ToCharArray();
             

            for (int i = 0; i < arrayString.Length; i++)
            {
                if (arrayString[i] != arrayString2[i] || arrayString.Length > arrayString2.Length)
                {
                    return false;
                }
            }
            return true;

        }
    }
}
