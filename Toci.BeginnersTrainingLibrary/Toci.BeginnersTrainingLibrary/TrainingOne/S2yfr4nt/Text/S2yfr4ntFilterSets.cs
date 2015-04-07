using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.S2yfr4nt.Text
{
    public class S2yfr4ntFilterSets
    {
        public string[] GetPalindroms(string[] palindromCandidatesList)
        {

            List<string> correctWordsList = new List<string>();
            foreach (var word in palindromCandidatesList)
            {
                if(S2yfr4ntTextUtils.IsPalindrom(word))
                    correctWordsList.Add(word);
            }

            return correctWordsList.ToArray();
        }

        public string[] GetAnagrams(string[] anagramCandidatesList, string anagram)
        {

            List<string> correctWordsList = new List<string>();
            foreach (var word in anagramCandidatesList)
            {
                if (S2yfr4ntTextUtils.IsAnagram(word, anagram))
                    correctWordsList.Add(word);
            }

            return correctWordsList.ToArray();

        }

        public string[] GetWildCards(string[] wildCardCandidatesList, string wildcard)
        {

            List<string> correctWordsList = new List<string>();
            foreach (var word in wildCardCandidatesList)
            {
                if (S2yfr4ntTextUtils.IsWildCard(word, wildcard))
                    correctWordsList.Add(word);
            }

            return correctWordsList.ToArray();

        }
    }
}
