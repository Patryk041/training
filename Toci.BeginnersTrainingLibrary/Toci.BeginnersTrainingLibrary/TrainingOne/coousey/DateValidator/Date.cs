using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.coousey.DateValidator
{
    class Date
    {
        public int Year { get; private set; }
        public int Day { get; private set; }
        public int Month { get; private set; }

        public bool DayIsValid { private get; set; }
        public bool MonthIsValid { private get; set; }
        public bool YearIsValid { private get; set; }

        public Date(int year, int month, int day)
        {
            Year = year;
            Day = day;
            Month = month;

            YearIsValid = true;
            DayIsValid = true;
            MonthIsValid = true;
        }

        public bool IsValid()
        {
            return YearIsValid && MonthIsValid && DayIsValid;
        }
    }
}
