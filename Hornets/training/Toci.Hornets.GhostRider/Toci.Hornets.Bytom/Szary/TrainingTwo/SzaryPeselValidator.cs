
using Toci.Hornets.Bytom.Szary.TrainingTwo.DateOperations;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Bytom.Szary.TrainingTwo
{
    public class SzaryPeselValidator:PeselValidator
    {

        protected override string CutOffDate(string pesel)
        {
            var insDateFromPesel = new DateFromPesel();
            var str = insDateFromPesel.GetPesel(pesel);
            var date = str.year + "-" + str.month + "-" + str.day;
            return date;
        }

        protected override bool Checksum(string pesel)
        {
            if (pesel.Length != 11)
            {
                return false;
            }
            else
            {
                var sum = new CheckSum.CheckSum();
                return (sum.Suma(pesel) % 10 == 0);
            }
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            var objDays = new Days();
            return Years.Year(year) && Months.Month(month) && objDays.Day(year, month, day);
        }

        public override string GetNick()
        {
            return "Szary";
        }

        public override bool IsPeselValid(string pesel)
        {
            DateFromPesel dateFromPesel = new DateFromPesel();
            var nice = dateFromPesel.GetPesel(pesel);
            CutOffDate(pesel);
            return Checksum(pesel) && ValidateDate(nice.year, nice.month, nice.day);
        }
    }
}