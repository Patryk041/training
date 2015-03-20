namespace Toci.TraininigLibrary.Developers.Chmura.DateTimeValidator
{
    public class DateValidator : IDateValidator
    {
        private Year _year;
        private Month _month;
        private Day _day;


        public bool DateValidate(int y, int m, int d)
        {
           _year = new Year(y);
            _month = new Month(m);
            _day = new Day(d);

            return _year.validate() && _month.Validate() && _day.Validate(_month, _year);

        }



        public string GetName()
        {
            return "chmura";
        }
    }
}
