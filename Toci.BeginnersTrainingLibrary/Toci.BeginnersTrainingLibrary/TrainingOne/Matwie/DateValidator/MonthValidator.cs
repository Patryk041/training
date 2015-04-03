using System;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Matwie.DateValidator
{
    class MonthValidator
    {
        private const int MIN_MONTH = 1;
        private const int MAX_MONTH = 12;

        public static bool IsValid(int year, int month, int day)
        {
            if (month >= MIN_MONTH && month <= MAX_MONTH)
                return true;

            throw new Exception();
        }
    }
}
