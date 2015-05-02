using Toci.BeginnersTrainingLibrary.TrainingOne.Wiosna.DataValidator.WiosnaInterfaces;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Wiosna.DataValidator
{
    public class DayValidation : IDayValidation
    {

        public bool DayValid(int _day, int _month, int _year)
        {
            MonthAndMonthLength monthAndMonthLength = new MonthAndMonthLength();
            
            
            return (monthAndMonthLength.GetMonth(_month,_day,_year));
        }
    }
}
