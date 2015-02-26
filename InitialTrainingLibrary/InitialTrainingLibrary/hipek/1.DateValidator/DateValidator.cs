using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces;

namespace InitialTrainingLibrary.hipek._1.DateValidator
{
    public class DateValidator : IDateValidator
    {
        public bool DateValidate(int year, int month, int day)
        {
            try
            {
                return DateValidatorFactory.CreateDateValidator(month).DateValidate(year, month, day);
            }
            catch (System.Collections.Generic.KeyNotFoundException)
            {

                return false;
            }

            
        }

        public string GetName()
        {
            return "Radek";
        }
    }
}
