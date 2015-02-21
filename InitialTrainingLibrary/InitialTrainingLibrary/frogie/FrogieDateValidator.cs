using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces;

namespace InitialTrainingLibrary.frogie
{
    public class FrogieDateValidator : IDateValidator
    {
        public bool DateValidate(int year, int month, int day)
        {
            if (day > 31 || month > 12)
            {
                return false;
            }
          
            if ((month < 8 && month % 2 == 0) || (month >= 8 && month % 2 == 1))
            {
                if (day > 30)
                    return false;
            }
            return true;
        }

        public string GetName()
        {

            return "frogie";
        }
    }
}
