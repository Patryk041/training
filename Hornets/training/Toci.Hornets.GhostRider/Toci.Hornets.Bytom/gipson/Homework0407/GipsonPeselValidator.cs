using System;
using System.Collections;
using System.Collections.Generic;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Bytom.gipson.Homework0407
{
    public class GipsonPeselValidator : PeselValidator
    {

        //returns string containing date in format:
        // yyyymmdd : y-year, m-month, d-day
        protected override string CutOffDate(string pesel)
        {
            //wrong pesel length
            if (pesel.Length != 11)
            {
                return null;
            }
            //variable for cut date
            string dateFromPesel = pesel.Substring(0, 6);

            Dictionary<string, string> dictionary = new Dictionary<string, string>()
            {
                {"0", "19"},
                {"1", "19"},
                {"2", "20"},
                {"3", "20"},
                {"4", "21"},
                {"5", "21"},
                {"6", "22"},
                {"7", "22"},
                {"8", "18"},
                {"9", "18"},
            };
            string miesiac = dateFromPesel.Substring(2, 1);
            if (dictionary.ContainsKey(miesiac))
            {
                dateFromPesel = dictionary[miesiac] +
                    dateFromPesel.Substring(0, 2) +
                    (0 + (int.Parse(miesiac) % 2)).ToString() +
                    dateFromPesel.Substring(3, 3);
            }
            return dateFromPesel;
        }

        protected int EvalChecksum(string pesel)
        {
            var checksum = Int32.Parse(pesel[0].ToString());
            checksum += Int32.Parse(pesel[1].ToString()) * 3;
            checksum += Int32.Parse(pesel[2].ToString()) * 7;
            checksum += Int32.Parse(pesel[3].ToString()) * 9;
            checksum += Int32.Parse(pesel[4].ToString());
            checksum += Int32.Parse(pesel[5].ToString()) * 3;
            checksum += Int32.Parse(pesel[6].ToString()) * 7;
            checksum += Int32.Parse(pesel[7].ToString()) * 9;
            checksum += Int32.Parse(pesel[8].ToString());
            checksum += Int32.Parse(pesel[9].ToString()) * 3;

            string checksumString = checksum.ToString();
            return (10 - Int32.Parse(checksumString[checksumString.Length - 1].ToString())) % 10;
        }

        protected override bool Checksum(string pesel)
        {
            if (pesel.Length != 11)
            {
                return false;
            }
            long temp;
            int checksum;
            //checking if pesel is number
            if (Int64.TryParse(pesel, out temp) == false)
            {
                return false;
            }
            else
            {
                checksum = EvalChecksum(pesel);
            }
            return checksum == Int32.Parse(pesel[pesel.Length - 1].ToString());
        }

        //returns true if year is leap, else returns false
        protected bool IsYearLeap(int year)
        {
            return year%4 == 0 && (year%100 != 0 || year%400 == 0);
        }


        //returns true if input date is a valid date
        //else returns false
        protected override bool ValidateDate(int year, int month, int day)
        {
            if (day < 1 || day > 31)
                return false;

            if (month < 1 || month > 12)
                return false;
            int[] shortMonths = new[] {4, 6, 9, 11};
            if (((IList) shortMonths).Contains(month) && day > 30)
                return false;

            if (month == 2 && IsYearLeap(year) && day > 29)
                return false;

            if (month == 2 && !IsYearLeap(year) && day > 28)
                return false;

            return true;
        }

        // return : my nick
        public override string GetNick()
        {
            return "gipson";
        }

        public override bool IsPeselValid(string pesel)
        {
            if (pesel.Length != 11)
                return false;
            string date = CutOffDate(pesel);

            return Checksum(pesel) && ValidateDate(Int32.Parse(pesel.Substring(0, 4)),
                Int32.Parse(pesel.Substring(4, 2)), Int32.Parse(pesel.Substring(6, 2)));

        }
    }
}