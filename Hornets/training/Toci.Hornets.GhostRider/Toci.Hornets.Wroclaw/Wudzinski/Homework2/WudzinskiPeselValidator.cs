using System.Collections.Generic;
using System.IO;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Wroclaw.Wudzinski.Homework2
{
    public class WudzinskiPeselValidator : PeselValidator
    {

        protected override string CutOffDate(string pesel)
        {
            return pesel.Length == 11 ? pesel.Substring(6) : "Pesel is too short !!!";
        }

        protected override bool Checksum(string pesel)
        {
            return true;
            //TODO
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            Dictionary<int, int> siema = new Dictionary<int, int>();
            siema.Add(80, 1800);
            siema.Add(60, 2200);
            siema.Add(40, 2100);
            siema.Add(20, 2000);
            siema.Add(0, 1900);

            var monthDiff = 0;
            var yearDiff = 0;
            foreach (KeyValuePair<int, int> entry in siema)
            {
                if (month > entry.Key && month < entry.Key + 20)
                {
                    monthDiff = entry.Key;
                    yearDiff = entry.Value;
                } 
            }

            year += yearDiff;
            month -= monthDiff;

           // if (month > 12 || month <=0) return false;
            //TODODODO
            return true;
        }

        public override string GetNick()
        {
            return "Wudzinski";
        }

        public override bool IsPeselValid(string pesel)
        {
            return true; //Checksum(pesel) && ValidateDate(year, month, day);
        }
    }
}