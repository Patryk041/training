using System;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Recha.TextOperations
{
    public class Wildcard : Expression
    {
        private string pattern;

        public Wildcard(string[] words) : base(words) { }

        public string Pattern
        {
            set { pattern = value; }
        }

        protected override bool isWordCorrectCheck(string word)
        {
            if (word.Length < pattern.Length)
                return false;
            else if (!(word.Substring(0, pattern.Length) == pattern))
                return false;
            return true;
        }
    }
}
