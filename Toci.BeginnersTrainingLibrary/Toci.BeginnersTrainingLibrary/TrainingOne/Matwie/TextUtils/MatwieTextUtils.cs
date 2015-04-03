using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Matwie.TextUtils
{
    class MatwieTextUtils :ITextOperationsSets
    {
        private Palindroms palindroms;
        private Anagrams anagrams;
        private Wildcards wildcards;

        public MatwieTextUtils(string[] potentiallyPalidroms, string[] potentiallyAnagrams, string[] potentiallyWildcards)
        {
            palindroms = new Palindroms(potentiallyPalidroms);
            anagrams = new Anagrams(potentiallyAnagrams);
            wildcards = new Wildcards(potentiallyWildcards);
        }

        public string GetNick()
        {
            return "matwie";
        }

        public string[] GetPalindromsSet()
        {
            return palindroms.Get();
        }

        public string[] GetAnagramsSet(string anagram)
        {
            return anagrams.Get(anagram);
        }

        public string[] GetWildCardSet(string wildcard)
        {
            return wildcards.Get(wildcard);
        }
    }
}
