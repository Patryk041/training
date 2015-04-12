using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.Doktor.DateValidator.Interfaces;
using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Doktor.DateValidator
{
    public class DayValidator : IDayValidator
    {
        public bool IsDayValid(int _day, int _month, int _year)
        {
            MonthValid month = new MonthValid();

            return (month.WhichMonth(_year, _month, _day));
        }
    }
}
