using System;

namespace Toci.Hornets.Legnica.Filip_Sokolowski.homeWork.peselValidator
{
    public class getDate
    {
        private int Day;
        private int Month;
        private int Year;

        public getDate(string pesel)
        {
            Year = int.Parse(pesel.Substring(0, 2));
            Month = int.Parse(pesel.Substring(2, 2));
            Day = int.Parse(pesel.Substring(4, 2));
            cutData(pesel);
        }

        public int getYear()
        {
            return Year;
        }

        public int getDay()
        {
            return Day;
        }

        public int getMonth()
        {
            return Month;
        }

        private void cutData(string pesel)
        {
            if (Month > 0 && Month < 13)
            {
                Year += 1900;
            }

            else if (Month > 20 && Month < 33)
            {
                Year += 2000;
                Month -= 20;
            }
            else if (Month > 40 && Month < 53)
            {
                Year += 2100;
                Month -= 40;
            }
            else if (Month > 40 && Month < 53)
            {
                Year += 2100;
                Month -= 40;
            }
            else if (Month > 60 && Month < 73)
            {
                Year += 2200;
                Month -= 60;
            }
            else if (Month > 80 && Month < 93)
            {
                Year += 1800;
                Month -= 80;
            }
        }

    }
}