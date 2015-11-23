using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.Rhonin.DataValidator
{
    public class RhoninDataValidator
    {
        bool DateValidate(int year, int month, int day)
        {
            return (ValidatorMonth.ValidateMonth(month) && ValidatorDay.ValidateDay(day,month,year) && ValidatorYear.ValidateYear(year));
        }
    }
}
