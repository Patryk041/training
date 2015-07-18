using System;

namespace Toci.Hornets.Rzeszow.KubaT.TrainingTwo.PeselValidator
{
    public class KubaTPeselValidator : GhostRider.YourWork.TasksTrainingTwo.PeselValidator
    {
        protected override string CutOffDate(string pesel)
        {
            return DateAdministrator.GetDate(pesel);
        }

        protected override bool Checksum(string pesel)
        {
            return SumValidation.IsValid(pesel);
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            return DateAdministrator.IsDateCorrect(year, month, day);
        }

        public override string GetNick()
        {
            return "KubaT";
        }

        public override bool IsPeselValid(string pesel)
        {
            if (pesel.Length != 11)
            {
                return false;
            }
            if (Checksum(pesel) == false)  
            {
                return false;
            }
            var peselDate = CutOffDate(pesel);
            var dayOfBirth = peselDate.Substring(4, 2);
            var monthOfBirth = peselDate.Substring(2, 2);
            var yearOfBirth = peselDate.Substring(0, 2);
            var dayOfBirthInt = Int32.Parse(dayOfBirth);
            var monthOfBirthInt = Int32.Parse(monthOfBirth);
            var yearOfBirthInt = Int32.Parse(yearOfBirth);
            return ValidateDate(yearOfBirthInt, monthOfBirthInt, dayOfBirthInt);
        }
    }
}