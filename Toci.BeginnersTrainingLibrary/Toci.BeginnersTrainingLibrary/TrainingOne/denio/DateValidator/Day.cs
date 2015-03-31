using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.denio.DateValidator
{
    public class Day
    {
        private const int MinDayNumber = 1;


        private const int LongMonthMaxDayNumber = 31;
        private const int ShortMonthMaxDayNumber = 30;
        private const int LongFebruaryMaxDayNumber = 29;
        private const int ShortFebruaryMaxDayNumber = 28;
        private const int Nothing = 0;
        private int _days;


        private const int January = 1;
        private const int February = 2;
        private const int March = 3;
        private const int April = 4;
        private const int May = 5;
        private const int June = 6;
        private const int July = 7;
        private const int August = 8;
        private const int September = 9;
        private const int October = 10;
        private const int Noveber = 11;
        private const int December = 12;


        private Dictionary<int, int> _months = new Dictionary<int, int>()
        {
            {January,   LongMonthMaxDayNumber},
            {March,     LongMonthMaxDayNumber},
            {May,       LongMonthMaxDayNumber},
            {July,      LongMonthMaxDayNumber},
            {August,    LongMonthMaxDayNumber},
            {October,   LongMonthMaxDayNumber},
            {December,  LongMonthMaxDayNumber},

            {April,     ShortMonthMaxDayNumber},
            {June,      ShortMonthMaxDayNumber},
            {September, ShortMonthMaxDayNumber},
            {Noveber,   ShortMonthMaxDayNumber},

            {February,  ShortFebruaryMaxDayNumber}
        };



        public int dayNumber(int month, int year)
        {
            Year rok = new Year();

            if (month == February && rok.Przestepny(year))
            {
                return LongFebruaryMaxDayNumber;
            }
            else
            {
                if (_months.TryGetValue(month, out _days))
                {
                    return _days;
                }
                    return Nothing;
            }
        }


        public bool ValidDay(int day, int month, int year)
        {
            
            return day >= MinDayNumber && day <= dayNumber(month, year);
        }
    }
}
