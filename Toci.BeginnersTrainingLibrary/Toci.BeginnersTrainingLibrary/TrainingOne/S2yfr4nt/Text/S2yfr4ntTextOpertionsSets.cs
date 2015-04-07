using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.S2yfr4nt.Text
{
    public class S2yfr4ntTextOpertionsSets: ITextOperationsSets
    {
        private string[] palindroms;
        private string[] anagrams;
        private string[] wildcards;

        public S2yfr4ntTextOpertionsSets(string[] _palindroms, string[] _anagrams, string[] _wildcards)
        {
            palindroms = _palindroms;
            anagrams = _anagrams;
            wildcards = _wildcards;
        }

        S2yfr4ntFilterSets filterSets = new S2yfr4ntFilterSets();

        public string GetNick()
        {
            return "S2yfr4nt";
        }

        public string[] GetPalindromsSet()
        {
            return filterSets.GetPalindroms(palindroms);  
        }

        public string[] GetAnagramsSet(string anagram)
        {
            return filterSets.GetAnagrams(anagrams, anagram);  
        }

        public string[] GetWildCardSet(string wildcard)
        {
            return filterSets.GetWildCards(wildcards, wildcard); 
        }
    }
}
