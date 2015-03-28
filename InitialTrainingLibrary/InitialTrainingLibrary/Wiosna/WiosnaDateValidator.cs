using InitialTrainingLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InitialTrainingLibrary.Wiosna.DateValidator
{
    public class WiosnaDateValidator : IDateValidator
    {
        public bool DateValidate(int day,int month,int year)
        {
            
            DayValidation Day = new DayValidation();
            Day.DayValid(day, month);

            MonthValidation Month = new MonthValidation();
            Month.MonthValid(month);

            YearValidation Year = new YearValidation();
            Year.YearValid(year);

            return (Day.DayValid(day, month) && Month.MonthValid(month) && Year.YearValid(year));
        }

    public string GetName()
    {
        return "Wiosna";
    }

    }
}
