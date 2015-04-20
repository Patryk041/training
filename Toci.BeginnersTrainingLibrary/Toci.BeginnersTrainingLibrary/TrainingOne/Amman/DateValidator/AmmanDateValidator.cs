using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.Amman.DateValidator.Workers;
using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Amman.DateValidator
{
    public class AmmanDateValidator : IDateValidator
    {
        public bool CheckDate(int year, int month, int day)
        {
            if (MonthValidator.isValid(month) && DayValidator.isValid(day, month, year)) 
                return true;
            else
                return false;
        }

        public string GetNick()
        {
            return "Amman";
        }
    }
}
