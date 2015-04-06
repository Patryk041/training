using System;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Matwie.TextUtils
{
    class Wildcards : Expressions
    {
        public Wildcards(string[] potentiallyWildcards) : base(potentiallyWildcards)
        {
        }

        protected override bool MatchToExpression(string word, string pattern)
        {
            return word.StartsWith(pattern);
        }
    }
}
