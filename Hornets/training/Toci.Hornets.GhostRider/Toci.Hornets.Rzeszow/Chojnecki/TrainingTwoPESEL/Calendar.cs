namespace Toci.Hornets.Rzeszow.Chojnecki.TrainingTwoPESEL
{
    public class Calendar
    {
        private readonly int _day;
        private int _month;
        private int _year;

        public Calendar(string pesel)
        {
            _month = int.Parse(pesel.Substring(2, 2));
            _year = int.Parse(pesel.Substring(0, 2));
            _day = int.Parse(pesel.Substring(4, 2));
            Date();
        }

        private void Date()
        {
            if (_month > 80 && _month < 93)
            {
                _year += 1800;
                _month -= 80;
            }
            else if (_month > 0 && _month < 13)
            {
                _year += 1900;
            }
            else if (_month > 20 && _month < 33)
            {
                _year += 2000;
                _month -= 20;
            }
            else if (_month > 40 && _month < 53)
            {
                _year += 2100;
                _month -= 40;
            }
            else if (_month > 60 && _month < 73)
            {
                _year += 2200;
                _month -= 60;
            }
        }

        public string GetYear()
        {
            return _year.ToString();
        }

        public string GetMonth()
        {
            if (_month < 10) return "0" + _month;
            return _month.ToString();
        }

        public string GetDay()
        {
            if (_day < 10) return "0" + _day;
            return _day.ToString();
        }
    }
}