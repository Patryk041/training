using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.koziu.DateValidator
{
    public class Month
    {
        private const int days31 = 31;
        private const int days30 = 30;

        private int _month;
        private Dictionary<int, int> _daysCount = new Dictionary<int, int>()
        {
            { 1, days31 },
            { 3, days31 },
            { 4, days30 },
            { 5, days31 },
            { 6, days30 },
            { 7, days31 },
            { 8, days31 },
            { 9, days30 },
            { 10, days31 },
            { 11, days30 },
            { 12, days31 },
        }; 

        public Month(int month)
        {
            _month = month;
        }
        public int GetMonth()
        {
            return _month;
        }

        public bool isMonth()
        {
            return (_month > 0 && _month < 13) ? true : false;
        }

        public int GetDaysCount()
        {
            return _daysCount.ContainsKey(_month) ? _daysCount[_month] : -1;
        }
    }
}
