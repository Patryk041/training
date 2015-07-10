using System;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
using Toci.Hornets.Sieradz.TypowyAdam.UndergroundTasks;

namespace Toci.Hornets.Sieradz.Duch.Homework_2.PeselValidator
{
    public class DuchPeselValidator : GhostRider.YourWork.TasksTrainingTwo.PeselValidator
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
            if (day > 31) return false;
            return
                month < 13 &&
                month > 0 &&
                PeselValidatorUtils.IsDayValid(year, month, day);
        }

        public override string GetNick()
        {
            return "Duch";
        }

        public override bool IsPeselValid(string pesel)
        {
            if (pesel.Length != 11) return false;
            if (!Checksum(pesel)) return false;

            var date = CutOffDate(pesel);

            int[] _pesel =
                {
                    Int32.Parse(date.Substring(0, 2)),
                    Int32.Parse(date.Substring(2,2)),
                    Int32.Parse(date.Substring(4,2))
                };
           

            var peselFactory = new DuchPeselFactory();
            var res = peselFactory.GetInstance(_pesel[1]);
            if (res == null) return false;
            
            _pesel[0] += res[0];
            _pesel[1] += res[1];

            
            return ValidateDate(_pesel[0], _pesel[1], _pesel[2]);
        }
    }
}