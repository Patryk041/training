namespace Toci.TraininigLibrary.Developers.Chmura.DateTimeValidator
{
    public class Year
    {
        private int year;

        public Year(int y)
        {
            year = y;
        }

        public bool isLeapYear()
        {
            return ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);
        }
        public bool validate()
        {
            return year > 1900 && year < 2100;
        }

    }
}
