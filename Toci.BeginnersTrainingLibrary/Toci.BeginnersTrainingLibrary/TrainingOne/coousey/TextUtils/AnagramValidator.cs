using System;


namespace Toci.BeginnersTrainingLibrary.TrainingOne.coousey.TextUtils
{
    public class AnagramValidator : ExpresionValidator
    {
        public override bool ValidateExpresion(string candidateExpresion, string patern)
        {
            char[] candidateExpresionArray = candidateExpresion.ToCharArray();
            char[] paternArray = patern.ToCharArray();

            Array.Sort(candidateExpresionArray);
            Array.Sort(paternArray);

            return new String(candidateExpresionArray).Equals(new string(paternArray));                    
        }
    }
}
