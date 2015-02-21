using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.syf.postcodevalidator.interfaces;

namespace InitialTrainingLibrary.syf.postcodevalidator
{
    public class RigthPostCodeValidatorBase : IPostCodeValidator
    {
        public virtual bool IsCodeValid(Province province, string code) //virtual
        {
            // TODO powolanie dostepu do bazy i select
            // zrobilismy to w bazie
            return true;
        }
    }
}
