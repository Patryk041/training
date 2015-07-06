using System;
using System.Globalization;

namespace Toci.Hornets.Bytom.Pr0fes0r.TrainingTwo.String
{
    public class SortrString
    {
        public char[] Sort(string word)
        {
           var wordChar = word.ToCharArray();
         
           Array.Sort(wordChar);

            return wordChar;
        }
    }
}