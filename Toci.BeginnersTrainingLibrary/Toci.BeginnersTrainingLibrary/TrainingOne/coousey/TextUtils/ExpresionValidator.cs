
using System.Linq;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.coousey.TextUtils
{
    public abstract class ExpresionValidator
    {
        public abstract bool ValidateExpresion(string candidateExpresion, string patern);

        public string[] GetValidExpresions(string[] candidateExpresions, string patern)
        {
            return candidateExpresions.Where(expresion => ValidateExpresion(expresion, patern)).ToArray();
        }
    }
}
