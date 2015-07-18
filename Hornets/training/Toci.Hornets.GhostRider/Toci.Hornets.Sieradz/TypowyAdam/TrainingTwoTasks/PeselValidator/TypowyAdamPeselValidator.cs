using System;
using System.Linq;
using System.Linq.Expressions;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Sieradz.TypowyAdam.UndergroundTasks
{
    public class TypowyAdamPeselValidator : PeselValidator
    {
        protected override string CutOffDate(string pesel)
        {
            return pesel.Substring(0, 6);
        }

        protected override bool Checksum(string pesel)
        {
            return PeselValidatorUtils.CheckCheckSum(pesel);
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            if (!PeselValidatorUtils.monthYearValid(ref year, ref month)) return false;

            return PeselValidatorUtils.IsDayValid(year, month, day);
        }

        public override string GetNick()
        {
            return "TypowyAdam";
        }

        public override bool IsPeselValid(string pesel)
        {
            if (pesel.Length != 11)
                return false;
            if (!Checksum(pesel))
                return false;
            
            char[] peselDate = CutOffDate(pesel).ToCharArray();
            int[] intDate =
            {
                (peselDate[4]-48)*10+(peselDate[5]-48),
                (peselDate[2]-48)*10+(peselDate[3]-48),
                (peselDate[0]-48)*10+(peselDate[1]-48)
            };
            return (ValidateDate(intDate[2], intDate[1], intDate[0]));

        }
    }
}