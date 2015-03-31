using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Wiosna.DateValidator.WiosnaInterfaces;

namespace InitialTrainingLibrary.Wiosna.DateValidator
{
    public class YearValidation : IYearValidation
    {

        public bool YearValid(int _year)
        {
            return (_year > 0); 
        }
    }
}
