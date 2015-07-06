using System;

namespace Toci.Hornets.Rzeszow.Terry.TrainingTwo.Pesel
{
    public class PeselDate
    {
        public int Day { get; set; } 
        public int Month { get; set; } 
        public int Year { get; set; } 
        public bool IsLeapYear { get; set; }
        public int Century { get; set; }

        public PeselDate(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
    }
}