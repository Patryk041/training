namespace Toci.BeginnersTrainingLibrary.TrainingOne.Zielu.TextValidator
{
    class ZieluWildcardValidation : ZieluTextValidation
    {
        protected override bool DoesMatch(string text, string pattern)
        {
            return text.StartsWith(pattern);
        }
    }
}
