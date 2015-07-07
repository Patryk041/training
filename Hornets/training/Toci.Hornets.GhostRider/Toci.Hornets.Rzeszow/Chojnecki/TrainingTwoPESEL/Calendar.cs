namespace Toci.Hornets.Rzeszow.Chojnecki.TrainingTwoPESEL
{
    public class Calendar
    {
        private readonly int day;
        private int month;
        private int year;

        public Calendar(string pesel)
        {
            month = int.Parse(pesel.Substring(2, 2));
            year = int.Parse(pesel.Substring(0, 2));
            day = int.Parse(pesel.Substring(4, 2));
            date();
        }

        private int date()
        {
            if (month > 80 && month < 93)
            {
                year += 1800;
                month -= 80;
            }
            else if (month > 0 && month < 13)
            {
                year += 1900;
            }
            else if (month > 20 && month < 33)
            {
                year += 2000;
                month -= 20;
            }
            else if (month > 40 && month < 53)
            {
                year += 2100;
                month -= 40;
            }
            else if (month > 60 && month < 73)
            {
                year += 2200;
                month -= 60;
            }
            return year;
        }

        public string getYear()
        {
            return year.ToString();
        }

        public string getMonth()
        {
            if (month < 10) return "0" + month;
            return month.ToString();
        }

        public string getDay()
        {
            if (day < 10) return "0" + day;
            return day.ToString();
        }
    }
}