namespace Toci.BeginnersTrainingLibrary.TrainingOne.Zielu.DateValidator
{
    public class ZieluMonthValidator
    {
        private const int MaxMonth = 13;
        private const int MinMonth = 0;
        public bool Validate(int month)
        {
            return MaxMonth > month && month > MinMonth;
        }
    }
}
