
namespace Toci.BeginnersTrainingLibrary.TrainingOne.coousey.DateValidator
{
    class YearValidator : IValidator
    {
        private const int MinYear = 0;
        private const int MaxYear = 9999;

        public void Validate(Date date)
        {          
            if((date.Year < MinYear) || (date.Year > MaxYear))
            {
                 date.YearIsValid = false;
            }
        }
    }
}
