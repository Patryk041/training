using System;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Zielu.DateValidator
{
    public class ZieluYearValidator
    {
        private const int MaxAllowedYear = Int32.MaxValue;
        private const int MinAllowedYear = -300;
        public bool Validate(int year)
        {
            return MaxAllowedYear > year && year > MinAllowedYear;
        }
    }
}
