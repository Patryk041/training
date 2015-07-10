using System;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Legnica.Michał_Zembik
{
    public class ZadaniePeselValidator : PeselValidator
    {
        protected override string CutOffDate(string pesel)
        {
            return pesel.Remove(6);
        }

        protected override bool Checksum(string pesel)
        {
            int sum = 0, a = 0, lastnum;

            if (pesel.Length != 11)
            {
                return false;
            }

            lastnum = int.Parse(pesel[10].ToString());
            int mnoznik = 1;
            for (int i = 0; i < pesel.Length - 1; i++)
            {
                a = int.Parse(pesel[i].ToString()) * mnoznik;
                mnoznik = mnoznik == 3 ? (mnoznik + 4) % 10 : (mnoznik + 2) % 10;
                sum += a;
            }
            a = sum % 10;
            sum = 10 - a;
            if (lastnum == sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            try
            {
                DateTime dt = new DateTime(year, month, day);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override string GetNick()
        {
            return "Michal Zembik";
        }

        public override bool IsPeselValid(string pesel)
        {
            string Date = CutOffDate(pesel);
            int year = int.Parse(Date.Remove(2));
            int month = int.Parse(Date.Substring(2, 2));
            int day = int.Parse(Date.Substring(4, 2));

            return Checksum(pesel) && ValidateDate(year, month, day);
        }
    }
}