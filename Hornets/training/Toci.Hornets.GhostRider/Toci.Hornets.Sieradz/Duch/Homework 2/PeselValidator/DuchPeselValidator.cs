using System;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
using Toci.Hornets.Sieradz.TypowyAdam.UndergroundTasks;


namespace Toci.Hornets.Sieradz.Duch.Homework_2.PeselValidator
{
    public class DuchPeselValidator : GhostRider.YourWork.TasksTrainingTwo.PeselValidator
    {
        private const int   PeselDateStart = 0,
                            PeselDateEnd = 6;

        readonly DuchPeselFactory _peselDateFactory = new DuchPeselFactory();

        protected override string CutOffDate(string pesel)
        {
            return pesel.Substring(PeselDateStart, PeselDateEnd);
        }

        protected override bool Checksum(string pesel)
        {
           return TypowyAdamPeselValidatorUtils.CheckCheckSum(pesel);
        }

        protected override bool ValidateDate(int year, int month, int day)
        {

            return DuchPeselUtils.IsMonthLenghtValid(month) &&
                    DuchPeselUtils.IsDayAmountValid(day) &&
                    TypowyAdamPeselValidatorUtils.IsDayValid(year, month, day);
        }

        public override string GetNick()
        {
            return "Duch";
        }

        public override bool IsPeselValid(string pesel)
        {
            var date = DuchPeselUtils.PeselDateMagic(CutOffDate(pesel));
            
            var dateModificationValues = _peselDateFactory.GetInstance(date[1]);
            if (dateModificationValues == null)                    return false;
                    
            date[0] += dateModificationValues[0];
            date[1] -= dateModificationValues[1];


            return DuchPeselUtils.IsPeselLenghtValid(pesel) &&
                   Checksum(pesel)                          &&
                   ValidateDate(date[0], date[1], date[2]);
        }
    }
}