using System;

namespace Toci.Hornets.Rzeszow.Polak.TrainingTwo
{
    public class DateContainer
    {
        private int _day;
        private int _month;
        private int _year;


        public void WhatIsWhat(string pesel)
        {
            _year = Convert.ToInt32(pesel.Substring(0, 2));
            _month = Convert.ToInt32(pesel.Substring(2, 2));
            _day= Convert.ToInt32(pesel.Substring(4,2));
            SetDate();
           
        }

        private void SetDate()
        {
            if (_month >= 81 && _month <= 92)
            {
                _year += 1800;
                _month -= 80;
            }
            if (_month >= 1 && _month <= 12)
            {
                _year += 1900;      
            }
            if (_month >= 21 && _month <= 32)
            {
                _year += 2000;
                _month -= 20;
            }
            if (_month >= 41 && _month <= 52)
            {
                _year += 2100;
                _month -= 40;
            }
            if (_month >= 61 && _month <= 72)
            {
                _year += 2200;
                _month -= 60;
            }  
        }



         public string SetYear()
         {
             return _year.ToString();
         }

        public string SetMonth()
        {
            return _month.ToString();
        }

        public string SetDay()
        {
            return _day.ToString();
        }




    }
}