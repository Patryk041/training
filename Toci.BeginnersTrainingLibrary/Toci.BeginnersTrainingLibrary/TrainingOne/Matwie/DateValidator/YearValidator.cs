using System;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Matwie.DateValidator
{
    class YearValidator
    {
        private const int MIN_YEAR = 1000;
        private const int MAX_YEAR = 2500;

        public static bool IsValid(int year, int month, int day)
        {
            if (year >= MIN_YEAR && year <= MAX_YEAR)
                return true;

            throw new Exception();
        }
    }
}
