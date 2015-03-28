 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Zly.TextOpeartionsSet
{
    public class ZlyFilterSets
    {
       public string[] GetPalindroms(string[] palindromCandidateList)
        {
      
        List<String> PalindromsList = new List<string>();
    
           foreach (var palindromCandidate in palindromCandidateList)
            {
                if (ZlyTextUtils.IsPalindrom(palindromCandidate))
                {
                    PalindromsList.Add(palindromCandidate);   
                }      
            }
        return PalindromsList.ToArray();

        }

        public string[] GetAnagrams(string[] anagramsCandidateList, string anagramPatern)
        {
            List<String> AnagramsList = new List<string>();

            foreach (var anagramCandidate in anagramsCandidateList)
            {
                if (ZlyTextUtils.IsAnagram(anagramCandidate, anagramPatern))
                {
                    AnagramsList.Add(anagramCandidate);
                }
            }
            return AnagramsList.ToArray();

        }


    }
}
