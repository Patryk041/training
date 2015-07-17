using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Bytom.InkNinja.TrainingTwo.PeselValidation
{
    class PeselValidation : PeselValidator
    {
        protected override string CutOffDate(string pesel)
        {
            string date = pesel.Substring(0, 6);
            return date;
        }
        protected override bool Checksum(string pesel)
        {
            int [] t = new int [11];
            for(int i=0; i<11; i++)
            {
                Int32.TryParse(pesel, out t[i]);
            }
            int sum = t[0] + 3 * t[1] + 7 * t[2] + 9 * t[3] + t[4] + 3 * t[5] + 7 * t[6] + 9 * t[7] + t[8] + 3 * t[9] + t[10];
            sum = sum % 10;
          
            return (sum == 0) ? true : false;
            // if (sum == 0) 
            //  return true;
            //else
            //  return false;
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            int [] days = new int[]{31,29,31,30,31,30,31,31,30,31,30,31};
            if (days[month] < day)
                return false;
            if (month != 2 || (month == 2 && day != 29) )
                return true;
            if (year % 4 != 0)
                return false;
            if (year % 100 != 0)
                return true;
            if (year % 400 != 0)
                return false;
            else
                return true;          
        }

        public override string GetNick()
        {
            return "InkNinja";
        }

        // cut, checksum, validate
        public override bool IsPeselValid(string pesel)
        {
            bool value;
            string date = CutOffDate(pesel);
            int[] dateNum = getDateNumbers(date);
            value = ValidateDate(dateNum[0], dateNum[1], dateNum[2]);
            value = value && Checksum(pesel);
            return value;
        }

        protected int[] getDateNumbers(string stringDate)
        {
            int [] date = new int [3];
            Int32.TryParse(stringDate.Substring(4, 2), out date[2]);
            Int32.TryParse(stringDate.Substring(2, 2), out date[1]);
            Int32.TryParse(stringDate.Substring(0, 2), out date[0]);
            if (date[1] > 72)
                date[0] = date[0] + 1800;
            else
                date[0] = date[0] + (date[1] / 20) * 100 + 1900;
            date[1] = date[1] % 20;
            return date;
        }
    }
}
