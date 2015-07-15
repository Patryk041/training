using System;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Wroclaw.Ayuu.TrainingTwo
{
    public class AyuuPeselValidator : PeselValidator
    {
        protected override string CutOffDate(string pesel)
        {
            return pesel.Substring(0, 6);
        }

        protected override bool Checksum(string pesel)
        {            
            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            var sum = 0;
            bool boolTemp;
            int num;
            var controlNumber = 0;
            boolTemp = int.TryParse(pesel.Substring(10, 1), out controlNumber);
            for (int i = 0; i < pesel.Length - 1; i++)
            {
                boolTemp = int.TryParse(pesel.Substring(i, 1), out num);
                sum += num*weights[i];
            }

            var controlSum = sum % 10;

            if (controlSum == 0 && controlSum == controlNumber)
                return true;
            return 10 - controlSum == controlNumber;
        }
    

        protected override bool ValidateDate(int year, int month, int day)
        {
            if (month < 20)
            {
                year += 1900;
            }
            else if (month < 40)
            {
                year += 2000;
                month -= 20;
            }
            else if (month < 60)
            {
                year += 2100;
                month -= 40;
            }
            else if (month < 80)
            {
                year += 2200;
                month -= 60;
            }
            else
            {
                year += 1800;
                month -= 80;
            }

            var dateString = year + "-" + month + "-" + day;
            DateTime dateOfBirth;
            if (!DateTime.TryParse(dateString, out dateOfBirth))
                return false;

            return dateOfBirth <= DateTime.Today;
        }

        public override string GetNick()
        {
            return "Ayuu";
        }
      
        public override bool IsPeselValid(string pesel)
        {
            if (pesel.Length != 11)
                return false;
            
            var date = CutOffDate(pesel);

            int year = Int32.Parse(date.Substring(0, 2));
            int month = Int32.Parse(date.Substring(2, 2));
            int day = Int32.Parse(date.Substring(4, 2));

            return ValidateDate(year, month, day) && Checksum(pesel);
        }
    }
}