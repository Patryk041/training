using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.Doktor.DateValidator.Interfaces;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Doktor.DateValidator
{
    public class MonthValidator : IMonthValidator
    {
        public bool IsMonthValid(int _month)
        {
            return (_month > 0 && _month < 13);
        }
    }
}
