using Toci.Hornets.Sieradz.Undergroun1Task.Interface;

namespace Toci.Hornets.Sieradz.TypowyAdam.UndergroundTasks
{
    public class TypowyAdamPeselValidator : IPeselValidator
    {
        public bool IsPeselValid(string pesel)
        {
            return true; // ValidateDate(x,x,x) == PeselValidatorUtils.CheckCheckSum(x,x);
        }

        public bool ValidateDate(int year, int month, int day)
        {
            throw new System.NotImplementedException();
        }
    }
}