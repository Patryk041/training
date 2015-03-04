using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces;

namespace InitialTrainingLibrary.Vernathic._01_DateValidator
{
    public class VDateValidator : IDateValidator
    {
        //DateValidator - TODO:
        //  1. create classes responsible for validate if set year, month, day gives correct date
        //  2. handle IDateValidator interface (do not use framework datetime type)

        //1. Get date
        //2. Extract date
        //3. Validate (check if Date is correct)
            //3.a   Day must be 1-28/29/30/31 - depends of the month
            //3.b   Month - 1-12
            //3.c   Leap year
        public bool DateValidate(int year, int month, int day)
        {
            //throw new NotImplementedException();
            if (VDay.IsCorrectDay(year, month, day))
                return true;
            else
                return false;
        }

        public string GetName()
        {
            return "Vernathic";
        }
    }
}