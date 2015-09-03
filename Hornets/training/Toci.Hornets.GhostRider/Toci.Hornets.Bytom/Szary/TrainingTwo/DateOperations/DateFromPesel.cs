

namespace Toci.Hornets.Bytom.Szary.TrainingTwo.DateOperations
{
    public class DateFromPesel
    {
        public Date GetPesel(string pesel)
        {
            int year = int.Parse(pesel.Substring(0, 2));
            int month = int.Parse(pesel.Substring(2, 2));
            int day = int.Parse(pesel.Substring(4, 2));

            return new Date(year, month, day);
        }

        public class Date
        {
            public Date(int y, int m, int d)
            {
                year = y;
                month = m;
                day = d;
            }
            public int year;
            public int month;
            public int day;

            public int Year()
            {
                return year;
            }

            public int Month()
            {
                return month;
            }

            public int Day()
            {
                return day;
            }
        }
    }
}