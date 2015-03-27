using System;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Recha
{
    public class Day
    {
        protected int day;

        public Day(int d)
        {
            day = d;
        }

        public bool checkDayValidate(int max)
        {
            if (day > 0 && day <= max)
                return true;
            return false;
        }
    }
}
