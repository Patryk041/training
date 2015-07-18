using System;

namespace Toci.Hornets.Sieradz.Jake.TrainingTwo.PeselValidator.tools
{
    public class CutDate
    {
        private int _day;
        private int _month;
        private int _year;
        private int _yearNumber;
        
        public CutDate (string pesel)
        {
            _day = Convert.ToInt32(pesel.Substring(4, 2));
            _month = Convert.ToInt32(pesel.Substring(2, 2));
            _year = Convert.ToInt32(pesel.Substring(0, 2));
            _yearNumber = Convert.ToInt32(pesel.Substring(2, 1));
        }

        public int CalculateYear()
        {
            int[] whatYear = {1900, 1900, 2000, 2000, 2100, 2100, 2200, 2200, 1800, 1800};

            return whatYear[_yearNumber] + _year;
        }

        public int CalculateMonth()
        {
            if (_yearNumber%2 == 0)
            {
                return _month - 10*_yearNumber;
            }

            return _month - 10*(_yearNumber + 1);
        }

        public int CalculateDay()
        {
            return _day;
        }

        public string FormatDate()
        {
            return CalculateDay().ToString() + "/" + CalculateMonth().ToString() + "/" + CalculateYear();
        }

        public int[] FormatDateToValidate()
        {
            int[] result =
            {
                CalculateDay(),
                CalculateMonth(),
                CalculateYear()
            };
            return result;
        }

    }
}