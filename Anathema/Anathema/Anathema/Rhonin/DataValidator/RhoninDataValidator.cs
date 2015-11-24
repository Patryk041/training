using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.Rhonin.DataValidator
{
    public class RhoninDataValidator
    {
        public bool DateValidate(int year, int month, int day)
        {
            if (ValidatorYear.ValidateYear(year))
                return (ValidatorMonth.ValidateMonth(month) && ValidatorDay.ValidateDay(day, month, year));
            return false;
        }
    }
}
