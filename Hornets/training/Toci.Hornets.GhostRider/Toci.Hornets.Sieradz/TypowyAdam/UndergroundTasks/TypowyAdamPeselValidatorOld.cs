using System;
using System.Diagnostics;
using System.Linq;
using Toci.Hornets.Sieradz.Undergroun1Task.Interface;

namespace Toci.Hornets.Sieradz.TypowyAdam.UndergroundTasks
{
    public class TypowyAdamPeselValidatorOld : IPeselValidator
    {
        public bool IsPeselValid(string pesel)
        {
            if (!TypowyAdamPeselValidatorUtils.CheckCheckSum(pesel))
                return false;
            if (pesel.Where(char.IsDigit).Count() != 11 && pesel.Length != 11)
                return false;


            int year = Convert.ToInt32(pesel.Substring(0,2));
            int month = Convert.ToInt32(pesel.Substring(2,2));
            int day = Convert.ToInt32(pesel.Substring(4, 2));
            return ValidateDate(year, month, day);

        }



        public bool ValidateDate(int year, int month, int day)
        {
            switch (month / 10)
            {
                case 0:
                case 1:
                    year += 1900;
                    break;
                case 2:
                case 3:
                    year += 2000;
                    break;
                case 4:
                case 5:
                    year += 2100;
                    break;
                case 6:
                case 7:
                    year += 2200;
                    break;
                case 8:
                case 9:
                    year += 1800;
                    break;
                default:
                    return false;
            }
            month = (month / 10) % 2 == 0 ? month - (month / 10 * 10) : month - (month / 10 * 10) + 10; //normalizacja miesiąca
            if (month <= 12 && month > 0)
                return TypowyAdamPeselValidatorUtils.IsDayValid(year, month, day);
            return false;
        }
    }
}