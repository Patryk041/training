using System;
using System.Linq;

namespace Toci.BeginnersTrainingLibrary.Hornets.Strategy
{
    public class SortAnagramRecognizer : AnagramRecognizer
    {
        public override bool IsAnagram(string candidate, string secondCandidate)
        {
            var candidateArray = candidate.ToCharArray();
            var secondCandidateArray = secondCandidate.ToCharArray();

            Array.Sort(candidateArray);
            Array.Sort(secondCandidateArray);

            return candidateArray.SequenceEqual(secondCandidateArray); 
        }
    }
}
