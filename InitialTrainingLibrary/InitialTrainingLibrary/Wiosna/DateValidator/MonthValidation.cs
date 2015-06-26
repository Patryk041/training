using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Wiosna.DateValidator.WiosnaInterfaces;

namespace InitialTrainingLibrary.Wiosna.DateValidator
{
    public class MonthValidation : IMonthValidation
    {
        public bool MonthValid(int _month)
        {
            return (_month > 0 && _month < 13); //return true if month is beetween 0 and 13
        }
    }
}
