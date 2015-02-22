using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.Sito._1
{
    class YearValidator:DatePartValidator
    {
        public override bool ValidatePart()
        {
            return this.partNumber >=0;
        }

        public YearValidator(int num) : base(num)
        {
        }
      
    }
}
