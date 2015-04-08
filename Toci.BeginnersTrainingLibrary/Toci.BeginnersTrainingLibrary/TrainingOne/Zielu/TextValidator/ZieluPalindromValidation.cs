using System.Linq;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Zielu.TextValidator
{
    class ZieluPalindromValidation :ZieluTextValidation
    {
        protected override bool DoesMatch(string text, string pattern)
        {
            return text == text.Reverse().ToString();
        }
    }
}
