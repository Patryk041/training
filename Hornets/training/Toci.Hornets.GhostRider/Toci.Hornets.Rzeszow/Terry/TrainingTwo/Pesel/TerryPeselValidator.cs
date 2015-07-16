using System;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Rzeszow.Terry.TrainingTwo.Pesel
{
    public class TerryPeselValidator : PeselValidator
    {
        protected override string CutOffDate(string pesel)
        {
            return pesel.Remove(6);
        }

        protected override bool Checksum(string pesel)
        {
            var digitsCharArr = pesel.ToCharArray();
            int[] digits = Array.ConvertAll(digitsCharArr, charArr => (int)Char.GetNumericValue(charArr));
            
            int controlSum = digits[0] + 3*digits[1] + 7*digits[2] + 9*digits[3] + digits[4] + 3*digits[5] + 7*digits[6] +
                             9*digits[7] + digits[8] + 3*digits[9];

            var lastDigit = controlSum % 10;

            if (lastDigit != 0) return (10 - lastDigit) == digits[10];
            return digits[10] == 0;
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            PeselDate date = new PeselDate(year, month, day);

            return MonthValidator.ValidateMonth(date) && YearValidator.ValidateYear(date) &&
                   DayValidator.ValidateDays(date);
        }

        public override string GetNick()
        {
            return "Terry";
        }

     
        public override bool IsPeselValid(string pesel)
        {
            string dateInPesel = CutOffDate(pesel);
            int day = Int32.Parse(dateInPesel.Substring(4));
            int month = Int32.Parse(dateInPesel.Substring(2, 2));
            int year = Int32.Parse(dateInPesel.Substring(0, 2));

            return ValidateDate(year, month, day) && Checksum(pesel);

        }
    }
}