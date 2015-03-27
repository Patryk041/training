using System;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Recha.TextOperations
{
    public class Anagram : Expression
    {
        private string pattern;

        public Anagram(string[] words) : base(words) { }

        public string Pattern
        {
            set { pattern = value; }
        }

        protected override bool isWordCorrectCheck(string word)
        {
            if (word.Length != pattern.Length)
                return false;
            else if (!checkLetters(word))
                return false;
            return true;
        }

        private bool checkLetters(string word)
        {
            char[] word1 = word.ToCharArray();
            char[] word2 = pattern.ToCharArray();

            Array.Sort(word1);
            Array.Sort(word2);

            if (word1 == word2)
                return false;

            return true;
        }
    }
}
