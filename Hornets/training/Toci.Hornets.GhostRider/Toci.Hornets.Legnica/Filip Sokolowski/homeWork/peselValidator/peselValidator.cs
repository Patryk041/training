using System;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Legnica.Filip_Sokolowski.homeWork.peselValidator
{
    public class peselValidator : PeselValidator
    {
        protected override string CutOffDate(string pesel)
        {
            var cuttedDate = new getDate(pesel);
            return cuttedDate.getDay().ToString() + "." + cuttedDate.getMonth().ToString() + "." +
                   cuttedDate.getYear().ToString();
        }

        protected override bool Checksum(string pesel)
        {
            int[] weights = {1, 3, 7, 9, 1, 3, 7, 9, 1, 3};
            int checkSum = CalculateCheckSum(pesel, weights);
            return checkSum == int.Parse(pesel[pesel.Length-1].ToString());
        }

        protected int CalculateCheckSum(string pesel, int[] weight)
        {
            int checksum = 0;
            for (int i = 0; i < pesel.Length-1 ; i++)
            {
                checksum += weight[i]*int.Parse(pesel[i].ToString());
            }
            if (10 - checksum == 10)
            {
                return 0;
            }
            return checksum;

        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            if (year < 1800 || year > 2299)
                return false;
            if (month > 12 || month < 0)
                return false;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (day > 0 && day < 32)
                        return true;
                    return false;
                case 2:
                    if(year % 400 == 0 || (year % 4 == 0 && year % 100 != 0 ))
                    {
                        return (day > 0 && day < 30);
                    }
                    return (day > 0 && day < 29);
                default:
                    return (day > 0 && day < 30);
            }
        }

        public override string GetNick()
        {
            return "Filip Sokolowski";
        }

        public override bool IsPeselValid(string pesel)
        {
            if (pesel.Length != 11)
                return false;
            if (!Checksum(pesel))
                return false;
            var cuttedDate = new getDate(pesel);
            return ValidateDate(cuttedDate.getYear(), cuttedDate.getMonth(), cuttedDate.getDay());
        }
    }
}