using System;
using System.Linq;
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
            if (month > 80) 
            {
                year += 1800;
                month -= 80;
            }
            else if (month > 60)
            {
                year += 2200;
                month -= 60;
            }
            else if (month > 40)
            {
                year += 2100;
                month -= 40;
            }
            else if (month > 20)
            {
                year += 2000;
                month -= 20;
            }
            else if (month <= 12)
            {
                year += 1900;
            }
            else return false;

            if (month > 12 || month <= 0) return false;
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