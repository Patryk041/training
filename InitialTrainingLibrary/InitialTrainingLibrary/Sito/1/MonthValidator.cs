
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.Sito._1
{
    class MonthValidator:DatePartValidator
    {

        public MonthValidator(int num) : base(num)
        {
        }

        public override bool ValidatePart()
        {
            return this.partNumber > 0 && this.partNumber < 13;
        }
    }
}
