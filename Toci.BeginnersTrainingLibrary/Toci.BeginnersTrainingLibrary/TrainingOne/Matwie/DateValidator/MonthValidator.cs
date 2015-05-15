namespace Toci.BeginnersTrainingLibrary.TrainingOne.Matwie.DateValidator
{
    class MonthValidator
    {
        private const int MinMonth = 1;
        private const int MaxMonth = 12;

        public static bool IsValid(int year, int month, int day)
        {
            return (month >= MinMonth && month <= MaxMonth);
        }
    }
}
