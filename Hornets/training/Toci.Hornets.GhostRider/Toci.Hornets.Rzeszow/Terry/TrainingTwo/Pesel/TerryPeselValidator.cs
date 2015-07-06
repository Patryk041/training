using System;

namespace Toci.Hornets.Rzeszow.Terry.TrainingTwo.Pesel
{
    public class TerryPeselValidator
    {
        protected string CutOffDate(string pesel)
        {
            return pesel.Remove(6);
        }

        protected bool Checksum(string pesel)
        {
            var digits = pesel.ToCharArray();

            int controlSum = digits[0];

            return controlSum == digits[10];
        }

        protected bool ValidateDate(int year, int month, int day)
        {
            PeselDate date = new PeselDate(year, month, day);

            return MonthValidator.ValidateMonth(date) && YearValidator.ValidateYear(date) &&
                   DayValidator.ValidateDays(date);
        }

        public string GetNick()
        {
            return "Terry";
        }

        // cut, checksum, validate
        public bool IsPeselValid(string pesel)
        {
            string dateInPesel = CutOffDate(pesel);
            int day = Int32.Parse(dateInPesel.Substring(4));
            int month = Int32.Parse(dateInPesel.Substring(2, 3));
            int year = Int32.Parse(dateInPesel.Substring(0, 1));

            return ValidateDate(year, month, day) && Checksum(pesel);

        }
    }
}