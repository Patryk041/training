using Toci.Hornets.Opole.Lausion.TasksTraningTwo.PeselValidator;

namespace Toci.Hornets.Sieradz.Jake.TrainingTwo.PeselValidator.tools
{
    public class IsCorrectDate
    {

        private bool isLeap(int year)
        {
            return (year % 4 == 0 && year % 100 != 0 || year % 400 == 0);
        }
        
        public bool isCorrectDay(int day, int month, int year)
        {
            int[] monthTable = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            int[] leapTable = {0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

            if (month > 13 || month <= 0)
            {
                return false;
            }

            if (isLeap(year))
            {
                if (day <= leapTable[month] && day > 0)
                {
                    return true;
                }
                return false;
            }
            else
            {
                if (day <= monthTable[month] && day > 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}