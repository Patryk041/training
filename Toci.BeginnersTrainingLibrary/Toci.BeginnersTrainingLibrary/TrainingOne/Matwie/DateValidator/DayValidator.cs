using System;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Matwie.DateValidator
{
    class DayValidator
    {
        private const int MIN_DAY = 1;

        public static bool IsValid(int year, int month, int day)
        {
            if (day >= MIN_DAY && day <= DateTime.DaysInMonth(year, month))
                return true;
        
            throw new Exception();
        }
    }
}
