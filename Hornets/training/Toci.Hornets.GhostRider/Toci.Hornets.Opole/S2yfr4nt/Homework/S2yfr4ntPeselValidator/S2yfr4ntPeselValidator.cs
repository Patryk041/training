using System;
using System.Collections.Generic;
using System.Linq;
using Toci.Hornets.Opole.S2yfr4nt.Homework.S2yfr4ntDateValidator;

namespace Toci.Hornets.Opole.S2yfr4nt.Homework.S2yfr4ntPeselValidator
{
    public class S2yfr4ntPeselValidator: PeselValidator
    {
        private int year;
        private int month;
        private int day;

        protected override bool ValidateDate(int year, int month, int day)
        {
            return S2yfr4ntYearValidation.ValidateYear(year) && S2yfr4ntMonthValidation.ValidateMonth(month) &&
                   S2yfr4ntDayValidation.ValidateDay(year, month, day);
        }

        public override bool IsPeselValid(string pesel)
        {
            GetDate(pesel);

            return ValidateDate(year, month, day) && ControlSum(pesel);
        }
        
        private void GetDate(string pesel)
        {
            year = Int32.Parse(pesel.Substring(0, 2));
            month = Int32.Parse(pesel.Substring(2, 2));
            day = Int32.Parse(pesel.Substring(4, 2));

            var key = peselYears.Keys.FirstOrDefault(x => x.Contains((month/10)));
            List<int> list = peselYears[key].Invoke(month, year);

            month = list.IndexOf(0);
            year = list.IndexOf(1);
        }

        private Dictionary<List<int>, Func<int, int, List<int>>> peselYears = new Dictionary<List<int>, Func<int, int, List<int>>>()
        {
            {new List<int>() {0, 1}, (m, y)=>new List<int>(){m, y+1900}},
            {new List<int>() {2, 3}, (m, y)=>new List<int>(){m-20, y+2000}},
            {new List<int>() {4, 5}, (m, y)=>new List<int>(){m-40, y+2100}},
            {new List<int>() {6, 7}, (m, y)=>new List<int>(){m-60, y+2200}},
            {new List<int>() {8, 9}, (m, y)=>new List<int>(){m-80, y+1800}},
        };

        private bool ControlSum(string pesel)
        {
            
            var charArray = pesel.Split();
            if (charArray.Length != 11)
                return false;

            int[] peselNums = new int[charArray.Length];
            int[] controlNums = new int[]{1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 0};
            int suma = 0;

            for (int i = 0; i < charArray.Length; i++)
            {
                peselNums[i] = Int32.Parse(charArray[i]);
                suma += peselNums[i]*controlNums[i];
            }

            return (10 - suma%10) == peselNums[charArray.Length];

        }
    }
}