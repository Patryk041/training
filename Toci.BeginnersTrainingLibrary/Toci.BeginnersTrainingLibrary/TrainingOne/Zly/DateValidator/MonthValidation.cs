using System.Collections.Generic;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Zly.DateValidator
{
    public class MonthValidation
    {
        private int _month;

        private const int minMonthLimit = 0;
        private const int maxMonthLimit = 13;

        private Dictionary<int, int> daysInMonth = new Dictionary<int, int>()
        {
            {1, 31},
            {2, 28},
            {3, 31},
            {4, 30},
            {5, 31},
            {6, 30},
            {7, 31},
            {8, 31},
            {9, 30},
            {10, 31},
            {11, 30},
            {12, 31},
        };

        public MonthValidation(int month)
        {
            _month = month;
        }

        public int NumberOfDaysInMonth(YearValidation yearPar)
        {
            if (yearPar.IsYearLeap())
            {
                daysInMonth.Remove(2);
                daysInMonth.Add(2,29);
            }

            return daysInMonth[_month];

        }

        public bool Validate()
        {
            return _month > minMonthLimit && _month < maxMonthLimit;
        }
    }
}
