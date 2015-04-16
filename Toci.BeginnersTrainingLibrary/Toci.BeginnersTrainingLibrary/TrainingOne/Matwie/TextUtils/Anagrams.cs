using System.Collections.Generic;
using System.Linq;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Matwie.TextUtils
{
    public class Anagrams : Expressions
    {
        public Anagrams(string[] potentiallyAnagrams) : base(potentiallyAnagrams)
        {
            
        }

        protected override bool MatchToExpression(string word, string pattern)
        {
            if (word.Length != pattern.Length)
                return false;

            List<char> charListWord = word.ToList();
            char[] charTablePattern = pattern.ToCharArray();

            foreach (char character in charTablePattern)
            {
                charListWord.Remove(character);
            }

            return !charListWord.Any();
        }
    }
}
