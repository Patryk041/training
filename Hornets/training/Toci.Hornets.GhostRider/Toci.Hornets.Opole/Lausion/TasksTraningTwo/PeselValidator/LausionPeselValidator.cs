
using System;

namespace Toci.Hornets.Opole.Lausion.TasksTraningTwo.PeselValidator
{
    public class LausionPeselValidator:Hornets.GhostRider.YourWork.TasksTrainingTwo.PeselValidator
    {
        protected override string CutOffDate(string pesel)
        {
            string date = pesel.Substring(0, 6);
            return date;
        }

        protected override bool Checksum(string pesel)
        {
            int suma = (Convert.ToInt32(pesel[0].ToString()) * 1) + (Convert.ToInt32(pesel[1].ToString()) * 3) +
                       (Convert.ToInt32(pesel[2].ToString()) * 7) +
                       (Convert.ToInt32(pesel[3].ToString()) * 9) + (Convert.ToInt32(pesel[4].ToString()) * 1) +
                       (Convert.ToInt32(pesel[5].ToString()) * 3) +
                       (Convert.ToInt32(pesel[6].ToString()) * 7) + (Convert.ToInt32(pesel[7].ToString()) * 9) +
                       (Convert.ToInt32(pesel[8].ToString()) * 1) +
                       (Convert.ToInt32(pesel[9].ToString()) * 3);
            int resztaSumy = suma % 10;



            if (((resztaSumy == 0) && (pesel[10] == 0)) || ((Convert.ToInt32(pesel[10].ToString()) == (10 - resztaSumy))))
                return true;
            else
            {
                return false;
            }
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            Year y=new Year(year);
            Month m=new Month(month);
            Day d=new Day(day);

            if (d.Validate(m, y))
                return true;
            else
            {
                return false;
            }
        }

        public override string GetNick()
        {
            return "Lausion";
        }

        public override bool IsPeselValid(string pesel)
        {
            string date = CutOffDate(pesel);
            int y = Convert.ToInt32(date.Substring(0, 2)) + 1900;//Dla ludzi urodzonych w latach 1900-1999
            int m = Convert.ToInt32(date.Substring(2, 2));
            int d = Convert.ToInt32(date.Substring(4, 2));
            //Dla ludzi urodzonych w latach 2000-2099
            if (m > 20 && m < 33)
            {
                m -= 20;
                y += 100;
            }

            if (Checksum(pesel) && ValidateDate(y, m, d))
                return true;
            else
            {
                return false;
            }


        }
    }
}