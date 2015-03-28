using InitialTrainingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InitialTrainingLibrary.Wiosna.DateValidator
{
    public class WiosnaDateValidator : Toci.BeginnersTrainingLibrary.TrainingOne.Excercise.IDateValidator
    {
        public bool CheckDate(int day,int month,int year)
        {
            
            DayValidation Day = new DayValidation();
            MonthValidation Month = new MonthValidation();
            YearValidation Year = new YearValidation();
            
            return (Day.DayValid(day, month,year) && Month.MonthValid(month) && Year.YearValid(year));
        }

        public string GetNick()
        {
            return "Wiosna";
        }


    }
}
