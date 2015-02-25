using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces;
using InitialTrainingLibrary.Sito._1;

namespace InitialTrainingLibrary.frogie.FrogieComplexDateValidator
{
    public class FrogieYetBetterDateValidator : IDateValidator
    {
        public bool DateValidate(int year, int month, int day)
        {
            FrogieDayValidator ddd = new FrogieDayValidator();
            return ddd.Validate(year, month, day);
        }

        public string GetName()
        {
            return "Frogie 3.0";
        }
    }
}
