using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Zly
{
    public class ZlyDateValidator : IDateValidator
    {
        public bool CheckDate(int year, int month, int day)
        {
           YearValidation yearToValid = new YearValidation(year);
           MonthValidation monthToValid = new MonthValidation(month);
            DayValidation dayToValid = new DayValidation(day);

            bool correctDate = false;
            correctDate = yearToValid.Validate() && monthToValid.Validate() &&
                          dayToValid.Validate(monthToValid, yearToValid);

            return correctDate;
        }

        public string GetNick()
        {
            return "Zly";
        }
    }
}
