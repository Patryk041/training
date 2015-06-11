using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Toci.BeginnersTrainingLibrary.Hornets.Algorythmics
{
    public class SillyAnagramRecognizer
    {
        private Dictionary<int, List<string>> anagramsDictionary;

        public bool IsAnagram(string candidate, string secondCandidate)
        {
            var candidateArray = candidate.ToCharArray();
            var secondCandidateArray = secondCandidate.ToCharArray();

            Array.Sort(candidateArray);
            Array.Sort(secondCandidateArray);

            return candidateArray.SequenceEqual(secondCandidateArray); 
            // a
            // a
        }

        public bool FaultyIsAnagram(string candidate, string secondCandidate)
        {
            // abc  -  97 98 99
            // c b a - 99 98 97
         

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

        public Dictionary<int,List<string>> ExtractAnagramsDictionary(List<string> candidatesList)
        {
            anagramsDictionary = new Dictionary<int, List<string>>();
            int countOfSublist = 0;
            List<string> currentAnagramsList = new List<string>();

            for (int i = 0; i < candidatesList.Count - 1; i++)
            {
                if(!currentAnagramsList.Contains(candidatesList[i])){
                    countOfSublist = candidatesList.Count - (i + 1);
                    currentAnagramsList.AddRange( ExtractAnagramsList(candidatesList[i], candidatesList.GetRange(i + 1, countOfSublist )) );
                }
            }
            return anagramsDictionary;
        }

        protected virtual bool MatchAnagrams(string candidate, string secondCandidate)
        {
            return (IsAnagram(candidate, secondCandidate));
        }

        private List<String> ExtractAnagramsList(string pattern, List<string> candidateList)
        {
            var anagramsList = (from candidate in candidateList
                        where MatchAnagrams(pattern,candidate)
                        select candidate).ToList();
            if (anagramsList.Count > 0)
            {
                anagramsList.Add(pattern);
                anagramsDictionary.Add(anagramsDictionary.Count, anagramsList);
                
            }
            return anagramsList;
        }
    }
}
