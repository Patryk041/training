using Toci.BeginnersTrainingLibrary.TrainingOne.Wiosna.DataValidator.WiosnaInterfaces;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Wiosna.DataValidator
{
    public class MonthValidation : IMonthValidation
    {
        public bool MonthValid(int _month)
        {
            return (_month > 0 && _month < 13); 
        }
    }
}
