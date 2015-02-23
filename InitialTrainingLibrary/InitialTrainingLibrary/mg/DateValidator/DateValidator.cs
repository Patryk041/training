using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces;

namespace InitialTrainingLibrary.mg.DateValidator
{
    public class DateValidator :IDateValidator
    {
        public bool DateValidate(int year, int month, int day)
        {
            ValidatorLogic validate = new ValidatorLogic();

            return year>=0 && (validate.GetValidation(year, month, day));
        }

        public string GetName()
        {
            return "mg";
        }
    }
}
