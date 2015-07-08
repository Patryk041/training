using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using Toci.Hornets.Opole.S2yfr4nt.Homework.S2yfr4ntDateValidator;

namespace Toci.Hornets.Opole.S2yfr4nt.Homework.S2yfr4ntPeselValidator
{
    public class S2yfr4ntPeselValidator : Hornets.GhostRider.YourWork.TasksTrainingTwo.PeselValidator
    {
        protected const int PESEL_LENGTH = 11;
        protected const int DATE_LENGTH = 6;
        protected const int DAY_LENGTH = 4;
        protected const int MONTH_LENGTH = 2;
        protected const int YEAR_LENGTH = 0;
        private const int SUB_LENGTH = 2;

        private int year;
        private int month;
        private int day;

        private int[] controlNums = new int[] { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 0 };
        

        protected override string CutOffDate(string pesel)
        {
            return pesel.Remove(DATE_LENGTH);
        }

        protected override bool Checksum(string pesel)
        {
            var peselArray = pesel.ToCharArray();
            if (peselArray.Length != PESEL_LENGTH)
                return false;
            
            int suma = peselArray.Select((t, i) => Int32.Parse(t.ToString())*controlNums[i]).Sum();
            return (10 - suma % 10) == Int32.Parse(peselArray.LastOrDefault().ToString());
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            return S2yfr4ntYearValidation.ValidateYear(year) && S2yfr4ntMonthValidation.ValidateMonth(month) &&
                   S2yfr4ntDayValidation.ValidateDay(year, month, day);
        }

        public override string GetNick()
        {
            return "S2yfr4nt";
        }

        public override bool IsPeselValid(string pesel)
        {
            bool a = GetDate(CutOffDate(pesel));
            bool b = ValidateDate(year, month, day);
            bool c = Checksum(pesel);
            return GetDate(CutOffDate(pesel)) && ValidateDate(year, month, day) && Checksum(pesel);
        }
        
        private bool GetDate(string date)
        {
            try
            {
                year = Int32.Parse(date.Substring(YEAR_LENGTH, SUB_LENGTH));
                month = Int32.Parse(date.Substring(MONTH_LENGTH, SUB_LENGTH));
                day = Int32.Parse(date.Substring(DAY_LENGTH, SUB_LENGTH));
            }
            catch (Exception)
            {
                return false;
            }

            S2yfr4ntPeselFactory monthAndYear = new S2yfr4ntPeselFactory();
            var list = monthAndYear.GetMonthYearList(month, year).ToArray();

            month = list[0];
            year = list[1];

            return true;
        }

    }
}