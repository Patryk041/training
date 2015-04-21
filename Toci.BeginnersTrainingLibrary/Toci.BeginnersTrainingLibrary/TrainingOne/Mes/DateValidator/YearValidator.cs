using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Mes.DateValidator
{
    public class YearValidator
    {


        public static bool IsLeapYear(int year)
        {


            return year % 100 == 0 ? year % 400 == 0 : year % 4 == 0;

        }
    }
}
