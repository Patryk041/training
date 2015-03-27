using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.denio.DateValidator
{
    public class Month
    {
        private int month;
        private int year;
        private int ilosc;

        private Dictionary<int, int> miesiace = new Dictionary<int, int>()
        {
            {1,31},
            {3,31},
            {4,30},
            {5,31},
            {6,30},
            {7,31},
            {8,31},
            {9,30},
            {10,31},
            {11,30},
            {12,31}
        };



        public int dayNumber(int m, int y)
        {
            month = m;
            year = y;

            if (month == 2)
            {
                Year rok = new Year();
                return rok.Przestepny(year);
            }
            else
            {
                if (miesiace.TryGetValue(month, out ilosc))
                {
                    return ilosc;
                }
                else
                {
                    return 0;
                }
            }
        }

        public bool ValidMonth(int m)
        {
            month = m;
            return month >= 1 && month < 13;
        }
    }
}
