namespace Toci.Hornets.Opole.Lausion.TasksTraningTwo.PeselValidator
{
    public class Day
    {
        private int day;
        private const int minimalDays = 1;
        public Day(int d)
        {
            day = d;
        }

        public bool Validate(Month m, Year y)
        {
            return day >= minimalDays && (day <= m.GetMaxDay(y)) ? true : false;
        }

    }
}