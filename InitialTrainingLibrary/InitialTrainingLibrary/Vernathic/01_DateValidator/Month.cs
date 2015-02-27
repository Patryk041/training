using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.Vernathic._01_DateValidator
{
    class Month
    {
        bool IsCorrectMonth(int month)
        {
            if (month >= 1 && month <= 12)
                return true;
            else return false;
        }
    }
}
