namespace Toci.BeginnersTrainingLibrary.TrainingOne.Matwie.TextUtils
{
    public abstract class Expressions
    {
        protected string[] candidates;
        protected string[] results;

        protected Expressions(string[] words)
        {
            candidates = words;
            results = new string[candidates.Length];
        }

        public string[] Get()
        {
            int i = 0;
            foreach (string candidate in candidates)
                if (MatchToExpression(candidate, null))
                    results[i++] = candidate;

            return results;
        }

        public string[] Get(string pattern)
        {
            int i = 0;
            foreach (string candidate in candidates)
                if (MatchToExpression(candidate, pattern))
                    results[i++] = candidate;

            return results;
        }

        protected abstract bool MatchToExpression(string word, string pattern);
    }
}
