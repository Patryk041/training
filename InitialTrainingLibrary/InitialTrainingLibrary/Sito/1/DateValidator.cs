using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using InitialTrainingLibrary.Interfaces;

namespace InitialTrainingLibrary.Sito._1
{
    public class DateValidator:IDateValidator
    {
        private List<DatePartValidator> partsToValidate = new List<DatePartValidator>();

        public DateValidator()
        {
            partsToValidate.Add(DatePartValidatorFactory.GetDatePartValidator(DateParts.Month));
            partsToValidate.Add(DatePartValidatorFactory.GetDatePartValidator(DateParts.Year));
            partsToValidate.Add(DatePartValidatorFactory.GetDatePartValidator(DateParts.Day));
        }
        public bool DateValidate(int year, int month, int day)
        {
            return partsToValidate.All(x => x.ValidatePart(day, month, year));
        }
        public string GetName()
        {
            return "Sito";
        }
    }
}
