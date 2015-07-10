using System;
using System.Collections;
using System.ComponentModel;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Wroclaw.AdamPast.Homework0407
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

            //"ifology"
            if (dateFromPesel.Substring(2, 1).Equals("8") || dateFromPesel.Substring(2, 1).Equals("9"))
            {
                dateFromPesel = "18"+dateFromPesel.Substring(0,2) +
                    (Int32.Parse(dateFromPesel.Substring(2, 1)) - 8).ToString() +
                    dateFromPesel.Substring(3,dateFromPesel.Length-1);
            }
            else if (dateFromPesel.Substring(2, 1).Equals("0") || dateFromPesel.Substring(2, 1).Equals("1"))
            {
                dateFromPesel = "19" + dateFromPesel;
            }
            else if (dateFromPesel.Substring(2, 1).Equals("2") || dateFromPesel.Substring(2, 1).Equals("3"))
            {
                dateFromPesel = "20" + dateFromPesel.Substring(0, 2) +
                    (Int32.Parse(dateFromPesel.Substring(2, 1)) - 2).ToString() +
                    dateFromPesel.Substring(3, dateFromPesel.Length - 1);
            }
            else if (dateFromPesel.Substring(2, 1).Equals("4") || dateFromPesel.Substring(2, 1).Equals("5"))
            {
                dateFromPesel = "21" + dateFromPesel.Substring(0, 2) +
                    (Int32.Parse(dateFromPesel.Substring(2, 1)) - 4).ToString() +
                    dateFromPesel.Substring(3, dateFromPesel.Length - 1);
            }
            else if (dateFromPesel.Substring(2, 1).Equals("6") || dateFromPesel.Substring(2, 1).Equals("7"))
            {
                dateFromPesel = "22" + dateFromPesel.Substring(0, 2) +
                    (Int32.Parse(dateFromPesel.Substring(2, 1)) - 6).ToString() +
                    dateFromPesel.Substring(3, dateFromPesel.Length - 1);
            }
            return dateFromPesel;


            //throw new NotImplementedException();
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
                checksum = Int32.Parse(pesel[0].ToString());
                checksum += Int32.Parse(pesel[1].ToString())*3;
                checksum += Int32.Parse(pesel[2].ToString())*7;
                checksum += Int32.Parse(pesel[3].ToString())*9;
                checksum += Int32.Parse(pesel[4].ToString());
                checksum += Int32.Parse(pesel[5].ToString()) * 3;
                checksum += Int32.Parse(pesel[6].ToString()) * 7;
                checksum += Int32.Parse(pesel[7].ToString()) * 9;
                checksum += Int32.Parse(pesel[8].ToString());
                checksum += Int32.Parse(pesel[9].ToString()) * 3;

                string checksumString = checksum.ToString();
                checksum = (10 - Int32.Parse(checksumString[checksumString.Length - 1].ToString()))%10;

            }
            return checksum == Int32.Parse(pesel[pesel.Length - 1].ToString());


            //throw new NotImplementedException();
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



            //throw new NotImplementedException();
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

            //throw new NotImplementedException();
        }
    }
}