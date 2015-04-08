using System;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Matwie.DateValidator
{
    class YearValidator
    {
        private const int MinYear = 1000;
        private const int MaxYear = 2500;

        public static bool IsValid(int year, int month, int day)
        {
            if (year >= MinYear && year <= MaxYear)
                return true;

            throw new Exception();
        }
    }
}
