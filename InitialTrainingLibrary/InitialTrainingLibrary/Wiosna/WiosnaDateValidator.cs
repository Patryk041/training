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
            MonthValidation Month = new MonthValidation();
            YearValidation Year = new YearValidation();
            

            return (Day.DayValid(day, month,year) && Month.MonthValid(month) && Year.YearValid(year));
        }

    public string GetName()
    {
        return "Wiosna";
    }

    }
}
