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
        private List<IDatePartValidator> partsValidators = new List<IDatePartValidator>();

        public DateValidator()
        {
            partsValidators.Add(new MonthValidator());
            partsValidators.Add(new YearValidator());
            partsValidators.Add(new DayValidator());
        }
        public bool DateValidate(int year, int month, int day)
        {
            return partsValidators.All(x => x.ValidatePart(day,month,year));
        }
        public string GetName()
        {
            return "Sito";
        }
    }
}
