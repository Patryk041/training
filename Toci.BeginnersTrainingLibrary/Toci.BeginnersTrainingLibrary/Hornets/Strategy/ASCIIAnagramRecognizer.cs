namespace Toci.BeginnersTrainingLibrary.Hornets.Strategy
{
    public class ASCIIAnagramRecognizer : AnagramRecognizer
    {
        public override bool IsAnagram(string candidate, string secondCandidate)
        {
            return Sum(candidate) == Sum(secondCandidate);
        }

        private int Sum(string candidate)
        {
            var sum = 0;
            foreach (var letter in candidate)
            {
                sum += (int)letter;

            }

            return sum;
        }
    }


}
