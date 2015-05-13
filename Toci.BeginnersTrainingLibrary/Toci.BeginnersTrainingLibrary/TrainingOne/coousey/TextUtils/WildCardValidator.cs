
namespace Toci.BeginnersTrainingLibrary.TrainingOne.coousey.TextUtils
{
    public class WildCardValidator : ExpresionValidator
    {
        public override bool ValidateExpresion(string candidateExpresion, string patern)
        {
            return candidateExpresion.StartsWith(patern);
        }
    }
}
