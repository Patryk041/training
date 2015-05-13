
using System;
using System.Linq;


namespace Toci.BeginnersTrainingLibrary.TrainingOne.coousey.TextUtils
{
    public class PalindromValidator : ExpresionValidator
    {
        public override bool ValidateExpresion(string candidateExpresion, string patern)
        {
            string reverseCandidateExprsion = new string(candidateExpresion.ToCharArray().Reverse().ToArray());
            return candidateExpresion.Equals(reverseCandidateExprsion);
        }
    }
}
