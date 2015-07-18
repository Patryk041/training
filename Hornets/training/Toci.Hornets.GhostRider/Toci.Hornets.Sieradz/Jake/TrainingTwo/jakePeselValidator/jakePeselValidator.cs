using System;
using System.Runtime.InteropServices.WindowsRuntime;
using Toci.Hornets.Sieradz.Jake.TrainingTwo.PeselValidator.tools;

namespace Toci.Hornets.Sieradz.Jake.TrainingTwo.PeselValidator
{
    public class jakePeselValidator : GhostRider.YourWork.TasksTrainingTwo.PeselValidator
    {
        protected override string CutOffDate(string pesel)
        {
            var myDateCut = new CutDate(pesel);
            return myDateCut.FormatDate();
        }

        protected override bool Checksum(string pesel)
        {
            var myChecksum = new PeselChecksum();
            return myChecksum.IsCorrect(pesel);
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            var myDate = new IsCorrectDate();
            return myDate.isCorrectDay(day, month, year);
        }

        public override string GetNick()
        {
            return "jake";
        }

        public override bool IsPeselValid(string pesel)
        {
            var myChecksum = new PeselChecksum();
            var myDate = new IsCorrectDate();
            var myDateCut = new CutDate(pesel);
            if (myChecksum.IsCorrect(pesel) &&
                myDate.isCorrectDay(myDateCut.CalculateDay(), myDateCut.CalculateMonth(), myDateCut.CalculateYear()))
            {
                return true;
            }
            return false;

        }
    }
}