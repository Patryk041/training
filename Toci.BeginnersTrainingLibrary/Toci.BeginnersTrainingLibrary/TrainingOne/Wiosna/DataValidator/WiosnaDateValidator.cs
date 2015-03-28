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
            Day.DayValid(day, month);

            MonthValidation Month = new MonthValidation();
            Month.MonthValid(month);

            YearValidation Year = new YearValidation();
            Year.YearValid(year);

            return (Day.DayValid(day, month) && Month.MonthValid(month) && Year.YearValid(year));
        }

        public string GetNick()
        {
            return "Wiosna";
        }


    }
}
