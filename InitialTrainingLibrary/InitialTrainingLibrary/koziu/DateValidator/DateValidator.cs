using InitialTrainingLibrary.Interfaces;
using InitialTrainingLibrary.koziu.DateValidator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.koziu.DateValidator
{
    public class DateValidator : IDateValidator
    {       
        public bool DateValidate(int year, int month, int day)
        {
            Year _year = new Year(year);
            Month _month = new Month(month);
            Day _day = new Day(day);   
            
            return _day.isDay(_year, _month);
        }
    }
}
