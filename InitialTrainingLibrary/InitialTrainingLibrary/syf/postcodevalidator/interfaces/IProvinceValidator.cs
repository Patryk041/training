using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.syf.postcodevalidator.interfaces
{
    public interface IProvinceValidator
    {
        bool IsCodeValid(PostCode code);
    }
}
