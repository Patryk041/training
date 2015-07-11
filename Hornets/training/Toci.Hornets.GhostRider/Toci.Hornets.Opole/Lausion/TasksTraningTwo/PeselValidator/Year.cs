namespace Toci.Hornets.Opole.Lausion.TasksTraningTwo.PeselValidator
{
    public class Year
    {
        private int year;
        public Year(int y)
        {
            year = y;
        }

        public bool IsLeap()
        {
            return ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);
        }


    }
}