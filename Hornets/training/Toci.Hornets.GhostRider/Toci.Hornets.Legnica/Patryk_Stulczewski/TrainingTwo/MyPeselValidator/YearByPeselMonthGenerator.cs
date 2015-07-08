using System;
using System.Collections.Generic;
using System.Linq;

namespace Toci.Hornets.Legnica.Patryk_Stulczewski.TrainingTwo.MyPeselValidator
{
    public static class YearByPeselMonthGenerator
    {
        private static Dictionary<Func<int, bool>, int> _centuryByMonth = new Dictionary<Func<int, bool>, int>()
            {
                {x => x >= 81 && x <= 92, 1800},
                {x => x >= 1 && x <= 12, 1900},
                {x => x >= 21 && x <= 32, 2000},
                {x => x >= 41 && x <= 52, 2100},
                {x => x >= 61 && x <= 72, 2200}
            };

        public static int GetYear(int month)
        {
            var century = _centuryByMonth.Keys.FirstOrDefault(x => x(month));
            if (century != null) 
                return _centuryByMonth[century];
            throw new IndexOutOfRangeException();
        }
    }
}