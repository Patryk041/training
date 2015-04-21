using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Mes.DateValidator
{
    public class MonthValidator
    {
        public static bool ValidateMonth(int month)
        {
            return month < 13 && month > 0 ? true : false;
        }
    }
}
