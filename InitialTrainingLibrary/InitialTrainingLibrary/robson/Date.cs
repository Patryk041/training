using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces;

namespace InitialTrainingLibrary.robson
{
    public class Date : IDateValidator
    {
        private readonly int[] monthLength = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };


        public bool DateValidate(int year, int month, int day)
        {
            if(year < 0)
            {
                return false;
            }
            if(CheckIfLeap(year))
            {
                if(month == 2)
                {
                    return (day > 0) && (day <= 29) ? true : false;
                }
            }
      
            if(month > 0 && month < 13)
            {
                return (day > 0) && (day <= monthLength[month - 1]) ? true : false;
            }
            else
            {
                return false;
            }
        }

        public string GetName()
        {
            return "Robert Winkler";
        }

        public bool CheckIfLeap(int year)
        {
            if((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
