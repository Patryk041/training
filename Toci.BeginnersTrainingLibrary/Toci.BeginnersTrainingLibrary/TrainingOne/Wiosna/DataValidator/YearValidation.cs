using Toci.BeginnersTrainingLibrary.TrainingOne.Wiosna.DataValidator.WiosnaInterfaces;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Wiosna.DataValidator
{
    public class YearValidation : IYearValidation
    {

        public bool YearValid(int _year)
        {
            return (_year > 0); 
        }
    }
}
