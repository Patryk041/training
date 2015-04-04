namespace Toci.BeginnersTrainingLibrary.TrainingOne.Matwie.TextUtils
{
    public abstract class Expressions
    {
        protected string[] Candidates;
        protected string[] Results;

        protected Expressions(string[] words)
        {
            Candidates = words;
            Results = new string[Candidates.Length];
        }

        public string[] Get(string pattern)
        {
            int i = 0;
            foreach (string candidate in Candidates)
                if (MatchToExpression(candidate, pattern))
                    Results[i++] = candidate;

            string[] returnedArray = new string[i];
            for (int j = 0; j < i; j++)
                returnedArray[j] = Results[j];

            return returnedArray;
        }

        protected abstract bool MatchToExpression(string word, string pattern);
    }
}
