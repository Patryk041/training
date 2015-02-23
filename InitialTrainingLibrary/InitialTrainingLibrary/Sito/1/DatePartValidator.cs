using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.Sito._1
{
    public abstract class DatePartValidator:IDatePartValidator
    {
        public abstract bool ValidatePart(int d, int m, int y);
    }
}
