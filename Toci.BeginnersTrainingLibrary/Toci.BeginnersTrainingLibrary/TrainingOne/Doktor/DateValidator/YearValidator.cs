using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.Doktor.DateValidator.Interfaces;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Doktor.DateValidator
{
    public class YearValidator : IYearValidator
    {
        public bool IsYearValid(int _year)
        {
            return (_year > 0 && _year < 2016);
        }
    }
}
