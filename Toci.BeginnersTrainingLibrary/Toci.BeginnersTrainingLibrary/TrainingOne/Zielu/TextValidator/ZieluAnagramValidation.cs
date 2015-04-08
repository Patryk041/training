using System;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Zielu.TextValidator
{
    class ZieluAnagramValidation : ZieluTextValidation
    {
        private char[] _anagram;

        private void PrepareStringForCompare(string anagram)
        {
            _anagram = anagram.ToCharArray();
            Array.Sort(_anagram);
        }

        protected override bool DoesMatch(string text, string pattern)
        {
            PrepareStringForCompare(pattern);
            var candidate = text.ToCharArray();
            Array.Sort(candidate);
            return candidate == _anagram;
        }
    }
}
