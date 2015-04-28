using DateValidator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateValidator
{
    public class MonthValidation:IMonthValidation
    {
        private const int MinMonthIndex = 0;
        private const int MaxMonthIndex = 12;

        public bool ValidMonth(int month)
        {
            return month>MinMonthIndex && month<=MaxMonthIndex;
        }
    }
}
