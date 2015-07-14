using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Toci.Hornets.Gliwice.usppat.TasksTrainingTwo.PeselValidator
{
    public class PeselValidatorVerUsppat : GhostRider.YourWork.TasksTrainingTwo.PeselValidator
    {
        public int year=0, month, day;

        protected override string CutOffDate(string pesel)
        {
            string date = pesel.Remove(6);
            return date;
        }



        protected void date(out int year, ref int month, ref int day, string cutenDate)
        {
            year = Convert.ToInt32(cutenDate.Remove(0, 2));
            month = Convert.ToInt32(cutenDate.Remove(2, 4));
            day = Convert.ToInt32(cutenDate.Remove(4, 6));
            year = yearFromPesel(year, month);
            month = monthFromPesel(month);
        }

        public int yearFromPesel(int year, int month)
        {
            if (month >= 80)
            {
                return (year + 1800);
            }
            if (month >= 1 && month <= 12)
            {
                return (year + 1900);
            }
            if (month >= 21 && month <= 32)
            {
                return (year + 2000);
            }
            if (month >= 41 && month <= 52)
            {
                return (year + 2100);
            }
            if (month >= 61 && month <= 72)
            {
                return (year + 2200);
            }
            return 0;
        }
        public int monthFromPesel(int month)
        {
            if (month >= 80)
            {
                return (month - 80);
            }
            if (month >= 1 && month <= 12)
            {
                return month;
            }
            if (month >= 21 && month <= 32)
            {
                return (month - 20);
            }
            if (month >= 41 && month <= 52)
            {
                return (month - 40);
            }
            if (month >= 61 && month <= 72)
            {
                return (month - 60);
            }
            return 0;

        }
    

        protected override bool Checksum(string pesel)
        {
            int sum;
            sum = 1*pesel[0] + 3*pesel[1] + 7*pesel[2]
                  + 9*pesel[3] + 1*pesel[4] + 3*pesel[5]
                  + 7*pesel[6] + 9*pesel[7] + 1*pesel[8]
                  + 3*pesel[9];
            sum = sum%10;
            sum = 10 - sum;
            if (sum == pesel[10])
            {
                return true;
            }
            return false;
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            if (year < 1800 || year > 2299)
            {
                return false;
            }
            if (month < 1 || month > 12)
            {
                return false;
            }
            if (day < 1 || day > 31)
            {
                return false;
            }
            if (month == 2 && day > 29)
            {
                return false;
            }
            if (((month <= 7 && month%2 == 0) || (month >= 8 && month%2 == 1)) && day == 31)
            {
                return false;
            }
            return true;
        }

        public override string GetNick()
        {
            return "usppat";
        }


        public override bool IsPeselValid(string pesel)
        {
            if (Checksum(pesel) == false || ValidateDate(year, month, day) == false)
            {
                return false;
            }
            return true;
        }
    }
}