using System;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Recha.DateValidator
{
    public static class Year
    {
        public static bool leapYearCheck(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                return true;
            return false;
        }
    }
}
