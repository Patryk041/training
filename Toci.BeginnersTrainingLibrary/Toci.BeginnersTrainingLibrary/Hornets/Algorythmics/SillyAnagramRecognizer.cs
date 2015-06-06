using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Toci.BeginnersTrainingLibrary.Hornets.Algorythmics
{
    public class SillyAnagramRecognizer
    {
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

        public string[] ExtractAnagramArray(string[] anagramArray)
        {
            List<string> resultArrayList = new List<string>();

            for (int i = 0; i < anagramArray.Count(); i++)
            {
                for (int j = 0; j < anagramArray.Count(); j++)
                {
                   
                }

            }
            
            return resultArrayList.ToArray();

        }

        protected virtual bool MatchAnagrams(string candidate,string secondCandidate)
        {

            return (IsAnagram(candidate, secondCandidate));

        }

    }
}
