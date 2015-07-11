using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Toci.Hornets.Gliwice.Didi.PeselTask
{
    class DataClass
    {
        private int _year;
        private int _month;
        private int _day;
        private bool _leapYear; 
        private Regex rgx;
        private static readonly List<int> _day30 = new List<int>(){03, 04, 06, 09 ,3,4,6,9,11}; 

        public DataClass(int year, int month, int day)
        {
            _year = year;
            _month = month;
            _day = day; 
        }

        private bool Day()
        {
            if (Month())
            {
                var month = _month.ToString(); 

                if (month.Contains(_day30.ToString()))
                {
                    string patternDay = @"[0]{1}[1-9]{1}|[1-2]{1}[0-9]{1}|[3]{1}[0]{1}";
                    return CheckNumber(patternDay, _day); 
                }
                else if (_month == 02 || _month == 2)
                {
                    if (_leapYear)
                    {
                        string patternDay = @"[0]{1}[1-9]{1}|[1-2]{1}[0-9]";
                        return CheckNumber(patternDay, _day);
                    }
                    else
                    {
                        string patternDay = @"[0]{1}[1-9]{1}|([1]{1}[0-9]{1}|[2]{1}[0-8]{1})";
                        return CheckNumber(patternDay, _day);
                    }
                }
                else
                {
                    string patternDay = @"[0]{1}[1-9]{1}|[1-2]{1}[0-9]{1}|[3]{1}[0-1]{1}";
                    return CheckNumber(patternDay, _day); 
                }
            }
            return false;
        }

        private bool  Month()
        {
            string monthPattern = @"[0]{1}[1-9]{1}|[1]{1}[0-2]{1}|[1-9]{1}";
            return CheckNumber(monthPattern, _month); 
        }

        private bool Year()
        {
            if ((0 <= _year & _year <= 9999))
            {
                IfLeapYear();
                return true;
            }
            return false;
        }

        private void IfLeapYear()
        {
            _leapYear = (_year%4 == 0) && (_year%100 != 0) || (_year%400 == 0);
        }

        private bool CheckNumber(string pattern, int input)
        {
           rgx = new Regex(pattern, RegexOptions.IgnoreCase);
           return rgx.IsMatch(input.ToString()); 
        }

        public bool ValidateDate()
        {
            return Year() & Month() & Day();
        }
    }
}
