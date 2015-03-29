using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Zly.TextOpeartionsSet
{
    public class ZlyTextUtils
    {
        public static bool IsPalindrom(string text)
        {
            int textLenght = text.Length;
            int i = textLenght/2;
            while (i-- > 0)
            {
                if (text[i] != text[textLenght - 1 - i]) return false;
            }
            return true;

        }

        private static int GetAsciSum(string text)
        {
            return 0;
        }

        public static bool IsAnagram(string pattern, string checkingWord)
        {
            var patternLetter = pattern.ToCharArray();
            var checkingLetter = checkingWord.ToCharArray();

            int asciSumOfpatternWord = 0; //GetAsciSum
            int asciSumOfcheckingWord = 0; //GetAsciSum

            for (int i = 0; i < patternLetter.Length; i++)
            {
                asciSumOfpatternWord += (int)patternLetter[i];
                asciSumOfcheckingWord += (int)checkingLetter[i];
            }

            return (asciSumOfpatternWord == asciSumOfcheckingWord);

        }

        public static bool IsWildCard(string text)
        {
            return true;
        }
    }

}
