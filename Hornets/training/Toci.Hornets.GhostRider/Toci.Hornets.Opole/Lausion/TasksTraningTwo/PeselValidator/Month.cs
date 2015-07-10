namespace Toci.Hornets.Opole.Lausion.TasksTraningTwo.PeselValidator
{
    public class Month
    {
        private int month;
        public Month(int m)
        {
            month = m;
        }

        public int GetMaxDay(Year y)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                {
                    return 31;
                    break;
                }
                case 4:
                case 6:
                case 9:
                case 11:
                {
                    return 30;
                    break;
                }
                case 2:
                {
                    if(y.IsLeap())
                        return 29;
                    else
                    {
                        return 28;
                    }
                }
                default:
                    return -1;



            }
        }
    }
}