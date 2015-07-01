using Toci.Hornets.GhostRider.TrainingTwo.Homework;

namespace Toci.Hornets.Opole.Startup.TrainingOne.Zielu
{
    public class ZieluPeselValidator : PeselValidator
    {

        protected override bool ValidateDate(int year, int month, int day)
        {
            return ZieluDateValidation.IsDateValid(year, month, day);
        }
        public override bool IsPeselValid(string pesel)
        {
            if (pesel.Length==11)
            {
                //var peselDigits = pesel.Split();
            }
            return false;
        }
    }
}
