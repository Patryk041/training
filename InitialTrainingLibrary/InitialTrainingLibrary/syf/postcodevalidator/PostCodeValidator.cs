using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.syf.postcodevalidator
{
    public class PostCodeValidator
    {
        public bool IsCodeValid(Province province, string code)
        {
            int prefix;
            int suffix;

            // 45-710

            prefix = int.Parse(code.Substring(0, 1));
            suffix = int.Parse(code.Substring(3, 5));

            if (province == Province.Dolnoslaskie)
            {
                if (prefix >= 45 && prefix < 47)
                {
                    //if ()
                }
            }

            return true;
        }
    }
}
