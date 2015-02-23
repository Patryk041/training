using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.Sito._1
{
    public static class DatePartValidatorFactory
    {
        private static Dictionary<DateParts, Func<DatePartValidator>> datePartsMap = new Dictionary
            <DateParts, Func<DatePartValidator>>()
        {
            {DateParts.Day, () => new DayValidator()},
            {DateParts.Month, () => new MonthValidator()},
            {DateParts.Year, () => new YearValidator()}
        };

        public static DatePartValidator GetDatePartValidator(DateParts datePart)
        {
            return datePartsMap[datePart].Invoke();
        }
    }
}
