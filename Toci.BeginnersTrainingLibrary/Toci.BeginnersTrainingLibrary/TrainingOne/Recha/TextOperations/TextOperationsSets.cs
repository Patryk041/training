using System;
using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Recha.TextOperations
{
    public class TextOperationsSets : ITextOperationsSets
    {
        private Palindrom palindroms;
        private Anagram anagrams;
        private Wildcard wildcards;

        public TextOperationsSets(string[] words1, string[] words2, string[] words3)
        {
            palindroms = new Palindrom(words1);
            anagrams = new Anagram(words2);
            wildcards = new Wildcard(words3);
        }

        public string GetNick()
        {
            return "By Marek Reszke";
        }

        public string[] GetPalindromsSet()
        {
            return palindroms.selectCorrectWords();
        }

        public string[] GetAnagramsSet(string anagram)
        {
            anagrams.Pattern = anagram;
            return anagrams.selectCorrectWords();
        }

        public string[] GetWildCardSet(string wildcard)
        {
            wildcards.Pattern = wildcard;
            return wildcards.selectCorrectWords();
        }
    }
}
