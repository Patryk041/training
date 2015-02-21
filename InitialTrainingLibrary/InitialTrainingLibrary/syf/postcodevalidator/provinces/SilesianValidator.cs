using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.syf.postcodevalidator.interfaces;

namespace InitialTrainingLibrary.syf.postcodevalidator.provinces
{
    public class SilesianValidator : IProvinceValidator
    {
        public bool IsCodeValid(PostCode code)
        {
            return code.Prefix() >= 47 && code.Prefix() <= 53;
        }
    }
}
