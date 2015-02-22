using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.Sito._1
{
    public abstract class DatePartValidator:IDatePartValidator
    {
        protected DatePartValidator(int num)
        {
            partNumber = num;
        }
        protected int partNumber ;
        public abstract bool ValidatePart();

    }
}
