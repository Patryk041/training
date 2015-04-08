using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Zielu.TextValidator
{
    public class ZieluTexts : ITextOperationsSets
    {
        private static string _anagramCandidate;
        private static string _palindromCandidate;
        private static string _wildcardCandidate;
        private static string _pattern;

        ZieluAnagramValidation Anagram = new ZieluAnagramValidation();
        ZieluPalindromValidation Palindrom = new ZieluPalindromValidation();
        ZieluWildcardValidation Wildcard = new ZieluWildcardValidation();

        public void SetAnagramCandidate(string text)
        {
            _anagramCandidate = text;
        }

        public void SetPattern(string text)
        {
            _pattern = text;
        }

        public void SetPalindromCandidate(string text)
        {
            _palindromCandidate = text;
        }

        public void SetWildcardCandidate(string text)
        {
            _wildcardCandidate = text;
        }
        public string GetNick()
        {
            return "Zielu";
        }

        public string[] GetPalindromsSet()
        {
            return Palindrom.Validate(_palindromCandidate, _pattern);
        }

        public string[] GetAnagramsSet(string anagram)
        {
            return Anagram.Validate(_anagramCandidate, _pattern);
        }

        public string[] GetWildCardSet(string wildcard)
        {
            return Wildcard.Validate(_wildcardCandidate, _pattern);
        }
    }
}
