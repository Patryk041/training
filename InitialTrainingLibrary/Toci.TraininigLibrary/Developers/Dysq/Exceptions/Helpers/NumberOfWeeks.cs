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
           var result= (dateOfReturnToCalulate - dateOfDepartureToCalculate).TotalDays/7;

            return (int)result;
        }

       
    }
}
