using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Mes.TextUtils 
{
    public class MesTextUtils : ITextOperationsSets
    {
        private Palindroms palindroms;
        private Anagrams anagrams;
        private Wildcards wildcards;

        public string GetNick()
        {
            return "Mes";
        }

        public MesTextUtils(string[] palindromCandidates, string[] anagramCandidates, string[] wildcardCandidates)
        {
            palindroms = new Palindroms(palindromCandidates);
            anagrams = new Anagrams(anagramCandidates);
            wildcards = new Wildcards(wildcardCandidates);
        }

        public string[] GetPalindromsSet()
        {
           return palindroms.GetFilteredList();
        }

        public string[] GetAnagramsSet(string anagram)
        {
            anagrams.SetPattern(anagram);
            return anagrams.GetFilteredList();
        }

        public string[] GetWildCardSet(string wildcard)
        {
            wildcards.SetPattern(wildcard);
            return wildcards.GetFilteredList();
        }
    }
}
