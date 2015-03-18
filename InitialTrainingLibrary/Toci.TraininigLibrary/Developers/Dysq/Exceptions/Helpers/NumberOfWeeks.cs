using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Dysq.Exceptions.Helpers
{
    public static class NumberOfWeeks
    {
        public static int CalculateNumberOfWeeks( DateTime dateOfReturnToCalulate, DateTime dateOfDepartureToCalculate)
        {
            const int totalDaysOfWeek = 7;
           var result= (dateOfReturnToCalulate - dateOfDepartureToCalculate).TotalDays/totalDaysOfWeek;

            return (int)result;
        }

       
    }
}
