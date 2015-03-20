namespace Toci.TraininigLibrary.Developers.Chmura.DateTimeValidator
{
    class Day
    {
        const int minimumDay = 1;

        private int day;

        public Day(int d)
        {
            day = d;
        }

        public bool Validate(Month m, Year y)
        {
            return (day > minimumDay && day <= m.GetDayCount(y));
        }
    }
}
