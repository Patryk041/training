using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Kielich
{
    public class Month
    {
        protected const int minMonth = 1;
        protected const int maxMonth = 12;

        private int month;

        public Month(int month)
        {
            this.month = month;
        }

        private Dictionary<int, int> months = new Dictionary<int, int>()
        {
            { 1, 31 },
            { 3, 31 },
            { 4, 30 },
            { 5, 31 },
            { 6, 30 }, 
            { 7, 31 }, 
            { 8, 31 }, 
            { 9, 30 }, 
            { 10, 31 }, 
            { 11, 30 }, 
            { 12, 31 },
        };

        public int Day(Year year)
        {
            if (month == 2 && year.Leap())
            {
                return 29;
            }
            if (month == 2)
            {
                return 28;
            }
            if (months.ContainsKey(month))
            {
                return months[month];
            }

            return 0;
        }

        public bool Validate()
        {
            return month >= minMonth && month <= maxMonth;
        }
        
    }
}
