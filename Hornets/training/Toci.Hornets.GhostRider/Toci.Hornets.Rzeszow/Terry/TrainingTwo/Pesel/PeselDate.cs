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

        public PeselDate(string peselPart)
        {
            Day = Int32.Parse(peselPart.Substring(4));
            Month = Int32.Parse(peselPart.Substring(2,3));
            Year = Int32.Parse(peselPart.Substring(0,1));
        }
    }
}