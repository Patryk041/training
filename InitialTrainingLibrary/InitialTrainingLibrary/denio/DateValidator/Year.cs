using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.denio.DateValidator
{
    public class Year
    {
        private int liczba;
        private int year;

        public int Przestepny(int y)
        {
            if ((y%4 == 0) && (y%100 != 0) || (y%400 == 0))
            {
                liczba = 29;
                return liczba;
            }
            else
            {
                liczba = 28;
                return liczba;
            }
        }

        public bool ValidYear(int y)
        {
            year = y;
            return year >= 1900 && year < 2100;
        }
    }
}
