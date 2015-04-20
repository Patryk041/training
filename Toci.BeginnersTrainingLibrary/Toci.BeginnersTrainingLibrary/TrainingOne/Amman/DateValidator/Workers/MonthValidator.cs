using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Amman.DateValidator.Workers
{
    class MonthValidator
    {
        public static bool isValid(int month)
        {
            if (month < 13 && month > 0) 
                return true;
            else
                return false;
        }
    }
}
