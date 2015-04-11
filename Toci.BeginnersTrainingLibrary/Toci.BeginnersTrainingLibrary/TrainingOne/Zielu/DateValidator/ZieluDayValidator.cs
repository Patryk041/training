namespace Toci.BeginnersTrainingLibrary.TrainingOne.Zielu.DateValidator
{
    public class ZieluDayValidator
    {
        readonly AllowedDays _maxDayEnabler = new AllowedDays();
        public bool Validate(int day, int month, int year)
        {
            var maxDay = _maxDayEnabler.MaxAllowedDay(year, month);
            return maxDay > day && day > 0;
        }
    }
}
