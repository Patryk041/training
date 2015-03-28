using System;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Recha.DateValidator
{
    public class Month
    {
        protected int month;

        public Month(int m)
        {
            month = m;
        }

        public bool checMonthValidate()
        {
            if (month > 0 && month < 13)
                return true;
            return false;
        }

        public int getMonthDaysCount(bool leapYear)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;

                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;

                default:
                    if (leapYear)
                        return 29;
                    else
                        return 28;
            }
        }
    }
}
