using System;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
using Toci.Hornets.Legnica.Adrianowsky94.PeselValidatorHW.PeselManipulationMethods;

namespace Toci.Hornets.Legnica.Adrianowsky94.PeselValidatorHW
{
    public class A94PeselValidator : PeselValidator
    {
        protected override string CutOffDate(string pesel)
        {
            return DateCutter.Cut(pesel);
        }

        protected override bool Checksum(string pesel)
        {
            return SumChecker.CheckSum(pesel);
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            return DateValidator.ValidateMonth(month) && DateValidator.ValidateDay(day);
        }

        public override string GetNick()
        {
            return "Adrianowsky94";
        }

        public override bool IsPeselValid(string pesel)
        {
            try
            {
                CutOffDate(pesel);
            }
            catch (Exception)
            {
                return false;
            }
            Date.GetYear();
            Date.GetMonth();
            Date.GetDay();

            return ValidateDate(Date.year, Date.month, Date.day) && Checksum(pesel);
        }
    }
}