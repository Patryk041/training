using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.Doktor.DateValidator.Interfaces;
using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Doktor.DateValidator
{
    public class DoktorDateValidator : IDateValidator 
    {

        public bool CheckDate(int year, int month, int day)
        {
            DayValidator Day = new DayValidator();
            MonthValidator Month = new MonthValidator();
            YearValidator Year = new YearValidator();

            return (Day.IsDayValid(day, month, year) && Month.IsMonthValid(month) && Year.IsYearValid(year));
        }

        

        public string GetNick()
        {
            return "Doktor";
        }
    }
}
