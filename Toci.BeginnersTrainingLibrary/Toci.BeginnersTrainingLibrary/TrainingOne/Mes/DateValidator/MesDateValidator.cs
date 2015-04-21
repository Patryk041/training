using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Mes.DateValidator
{
    public class MesDateValidator : IDateValidator
    {

        public bool CheckDate(int day, int month, int year)
        {
            return DayValidator.ValidateDay(day, month, year) && MonthValidator.ValidateMonth(month);
        }



        public string GetNick()
        {
            return "Mes";
        }
    }
}
