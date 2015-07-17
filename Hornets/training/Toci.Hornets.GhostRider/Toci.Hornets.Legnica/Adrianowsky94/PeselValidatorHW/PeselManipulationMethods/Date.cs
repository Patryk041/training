namespace Toci.Hornets.Legnica.Adrianowsky94.PeselValidatorHW.PeselManipulationMethods
{
    public class Date
    {
        public static int year;
        public static int month;
        public static int day;

        public static int GetYear()
        {
            if (month > 80 && month < 93)
                year += 1800;
            else if (month > 0 && month < 13)
                year += 1900;
            else if (month > 20 && month < 33)
                year += 2000;
            else if (month > 40 && month < 53)
                year += 2100;
            else if (month > 60 && month < 73)
                year += 2200;
            return year;
        }

        public static bool IfLeapYear()
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        public static int GetMonth()
        {
            if (month > 80 && month < 93)
                month -= 80;
            else if (month > 20 && month < 33)
                month -= 20;
            else if (month > 40 && month < 53)
                month -= 40;
            else if (month > 60 && month < 73) 
                month -= 60;
            return month;
        }

        public static int GetDay()
        {
            return day;
        }
    }
}