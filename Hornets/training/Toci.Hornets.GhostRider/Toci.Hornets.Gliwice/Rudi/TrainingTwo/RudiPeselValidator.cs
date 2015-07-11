using System;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Gliwice.Rudi
{
    public class RudiPeselValidator : PeselValidator
    {

        protected override string CutOffDate(string pesel)
        {
            int year = Int32.Parse(pesel.Substring(0, 2));
            int month = Int32.Parse(pesel.Substring(2, 4));
            int day = Int32.Parse(pesel.Substring(4, 6));

            switch (year%10)
            {
                case 0:
                case 1:
                    year += 1900;
                    break;
                case 2:
                case 3:
                    year += 2000;
                    break;
                case 4:
                case 5:
                    year += 2100;
                    break;
                case 6:
                case 7:
                    year += 2200;
                    break;
                case 8:
                case 9:
                    year += 1800;
                    break;
            }

            return year + "." + month + "." + day;

        }

        protected override bool Checksum(string pesel)
        {
            int suma = 0;
            int[] wagi = {1, 3, 7, 9, 1, 3, 7, 9, 1, 3};
            int[] intPesel = new int[11];
            char[] charPesel = pesel.ToCharArray();

            for(int i=0;i<wagi.Length;i++)
            {
                suma += (charPesel[i] - '0')*wagi[i];
            }

            if (suma%10 == charPesel[10])
                return true;

            return false;
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            if (year < 1800 && year > 2300)
            {
                return false;
            }
            else
            {
                if (month <= 1 && month >= 12)
                {
                    return false;
                }
                else
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
                            return (day > 31) ? true : false;

                        case 4:
                        case 6:
                        case 9:
                        case 11: return (day > 30) ? true : false;

                        case 2:
                            if ((year%4 == 0) && (year%100 != 0) || year%400 == 0)
                            {
                                return day <= 29 ? true : false;
                            }
                            else
                            {
                                return day <= 28 ? true : false;
                            }


                    }
                }
            }
            return false;
        }

        public override string GetNick()
        {
            throw new System.NotImplementedException();
        }

        public override bool IsPeselValid(string pesel)
        {
            throw new System.NotImplementedException();
        }
    }
}