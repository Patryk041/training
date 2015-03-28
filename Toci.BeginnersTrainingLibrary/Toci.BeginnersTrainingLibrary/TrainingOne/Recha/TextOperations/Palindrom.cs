using System;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Recha.TextOperations
{
    public class Palindrom : Expression
    {
        public Palindrom(string[] words) : base(words) { }

        protected override bool isWordCorrectCheck(string word)
        {
            if (word.Length % 2 == 0 || word.Length < 3)
                return false;
            else if (word != reverse(word))
                return false;
            return true;
        }

        private string reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
