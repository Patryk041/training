using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces;

namespace InitialTrainingLibrary.hipek._1.DateValidator
{
    public class LeapYear: IDateValidator
    {
        public bool DateValidate(int year, int month, int day)
        {
            bool ifLeapYear = (((year%4 == 0 && year%100 != 0) || year%400 == 0) && year >= 0);
            return DateValidatorFactory.CreateLeapYearValidator(ifLeapYear).DateValidate(year, month, day);
        }

        public string GetName()
        {
            return "Radek";
        }
    }
}
