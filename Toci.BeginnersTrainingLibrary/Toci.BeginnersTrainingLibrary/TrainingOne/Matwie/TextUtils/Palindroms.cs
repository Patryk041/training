namespace Toci.BeginnersTrainingLibrary.TrainingOne.Matwie.TextUtils
{
    public class Palindroms : Expressions
    {
        public Palindroms(string[] palindromCandidates) : base(palindromCandidates)
        {
        }

        protected override bool MatchToExpression(string word, string pattern)
        {
            for (int i = 0; i < word.Length/2; i++)
                if (word[i] != word[word.Length - 1 - i])
                    return false;

            return true;
        }
    }
}
