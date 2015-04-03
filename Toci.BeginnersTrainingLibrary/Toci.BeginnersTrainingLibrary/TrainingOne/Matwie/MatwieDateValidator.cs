using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Matwie
{
    public class MatwieDateValidator : IDateValidator
    {
        public bool CheckDate(int year, int month, int day)
        {
            return new YearValidator().isValid(year, month, day) && new MonthValidator().isValid(year, month, day) && new DayValidator().isValid(year, month, day);
        }

        public string GetNick()
        {
            return "matwie";
        }
    }
}
