namespace Toci.BeginnersTrainingLibrary.TrainingOne.Rubi.Interfaces
{
    public interface IDayValidation
    {
        bool VerifyLongMonthDay(int day);
        bool VerifyShortMonthDay(int day);
        bool VerifyLongFebruaryDay(int day);
        bool VerifyShortFebruaryDay(int day);
    }
}
