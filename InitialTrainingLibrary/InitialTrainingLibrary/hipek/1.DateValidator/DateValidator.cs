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

            var validator = DateValidatorFactory.CreateDateValidator(month);
            return validator != null && validator.DateValidate(year, month, day);
            

            
        }

        public string GetName()
        {
            return "Radek";
        }
    }
}
