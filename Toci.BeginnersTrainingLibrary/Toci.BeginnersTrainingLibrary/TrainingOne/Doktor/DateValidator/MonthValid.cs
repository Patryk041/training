using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.Doktor.DateValidator.Interfaces;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Doktor.DateValidator
{
    public class MonthValid : IMonthValid
    {
        public MonthList M;

        public bool WhichMonth(int y, int m, int d)
        {
            switch (m)
            {
                case 1:
                    M = MonthList.January;
                    return (d > 0 && d <= 31);
                /*case 2:
                    M = MonthList.February;
                    while (d > 0 && d <= 28)
                    {
                        Console.Write("Luty nieprzestępny");
                    }
                    */break;
                case 3:
                    M = MonthList.March;
                    return (d > 0 && d <= 31);
                case 4:
                    M = MonthList.April;
                    return (d > 0 && d <= 30);
                case 5:
                    M = MonthList.May;
                    return (d > 0 && d <= 31);
                case 6:
                    M = MonthList.June;
                    return (d > 0 && d <= 30);
                case 7:
                    M = MonthList.July;
                    return (d > 0 && d <= 31);
                case 8:
                    M = MonthList.August;
                    return (d > 0 && d <= 31);
                case 9:
                    M = MonthList.September;
                    return (d > 0 && d <= 30);
                case 10:
                    M = MonthList.October;
                    return (d > 0 && d <= 31);
                case 11:
                    M = MonthList.November;
                    return (d > 0 && d <= 30);
                case 12:
                    M = MonthList.December;
                    return (d > 0 && d <= 31);
                default:
                    return false;
            }
        }
    }
}
