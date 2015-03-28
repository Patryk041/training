using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Kielich
{
    public class Year
    {
        protected const int minYear = 1000;
        protected const int maxYear = 2500;

        private int year; 

        public Year(int year)
        {
            this.year = year;
        }

        public bool Leap()
        {
            return ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);
        }

        public bool Validate()
        {
            return year > minYear && year < maxYear; 
        }
    }
}
