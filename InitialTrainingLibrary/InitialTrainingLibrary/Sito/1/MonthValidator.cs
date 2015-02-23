
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.Sito._1
{
    class MonthValidator:DatePartValidator
    {
        public override bool ValidatePart(int d, int m, int y)
        {
            return m > 0 && m < 13;
        }
    }
}
