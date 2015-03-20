using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Eacrm;

namespace Toci.TraininigLibrary.Developers.Dysq.Exceptions.Helpers
{
    public static class DateHelper
    {
        public static bool CheckDates(DysqDepartureEntity element)
        {
            return element.DepartureDate > element.ReturnDate;
        }

        public static bool CheckDateInterval(DysqDeparturesList list, DysqDepartureEntity row)
        {
            var result = false;
            
            foreach (var element in list)
            {
                if (row.DepartureDate <= element.ReturnDate && row.DepartureDate >= element.DepartureDate)
                    result=true;
            }
            return result;
        }



    }
}
