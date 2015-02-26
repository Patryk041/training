using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces;

namespace InitialTrainingLibrary.hipek._1.DateValidator
{
    public class _29thMonthsDateValidator : IDateValidator
    {
        public bool DateValidate(int year, int month, int day)
        {
            return day >= 1 && day <= 29;
        }

        public string GetName()
        {
            return "Radek";
        }
    }
}
