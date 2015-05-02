using Toci.BeginnersTrainingLibrary.TrainingOne.Wiosna.DataValidator.DateParts;
using Toci.BeginnersTrainingLibrary.TrainingOne.Wiosna.DataValidator.WiosnaInterfaces;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Wiosna.DataValidator
{
    class MonthAndMonthLength :IMonthAndMonthLength
    {
        public MonthList MonthE;

        public bool GetMonth(int m,int d,int y)
        {
            switch (m)
            {
                case 01:
                    MonthE = MonthList.January;
                    return (d > 0 && d <= 31);
                    
                case 02:
                    MonthE = MonthList.February;
                    if (((y % 4 == 0 && y % 100 != 0) || y % 400 == 0)) // Is leap year
                    {
                        return (d > 0 && d <= 29);
                    }
                    return (d > 0 && d <= 28 );
                    
                case 03:
                    MonthE = MonthList.March;
                    return (d > 0 && d <= 30);
                    
                case 04:
                    MonthE = MonthList.April;
                    return (d > 0 && d <= 31);
                    
                case 05:
                    MonthE = MonthList.May;
                    return (d > 0 && d <= 30);
                    
                case 06:
                    MonthE = MonthList.June;
                    return (d > 0 && d <= 31);
                    
                case 07:
                    MonthE = MonthList.July;
                    return (d > 0 && d <= 30);
                    
                case 08:
                    MonthE = MonthList.August;
                    return (d > 0 && d <= 31);
                    
                case 09:
                    MonthE = MonthList.September;
                    return (d > 0 && d <= 30);
                    
                case 10:
                    MonthE = MonthList.October;
                    return (d > 0 && d <= 31);
                    
                case 11:
                    MonthE = MonthList.November;
                    return (d > 0 && d <= 30);
                    
                case 12:
                    MonthE = MonthList.December;
                    return (d > 0 && d <= 31);
                    
                default:
                    return false;
            }
        }
    }
}
