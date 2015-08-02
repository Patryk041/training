using System;

namespace Toci.Hornets.Bytom.Szary.TrainingTwo.StringTask
{
    public class SortString
    {
        public char[] Sort(string word)
        {
            var wordChar = word.ToCharArray();

            Array.Sort(wordChar);

            return wordChar;
        } 
    }
}