
namespace Toci.BeginnersTrainingLibrary.TrainingOne.coousey.DateValidator
{
    class MonthValidator : IValidator
    {
        private const int MinMonth = 1;
        private const int MaxMonth = 12;
        public void Validate(Date date)
        {
            if ((date.Month < MinMonth) || (date.Month > MaxMonth))
            {
                date.MonthIsValid = false;
            }
        }
    }
}
