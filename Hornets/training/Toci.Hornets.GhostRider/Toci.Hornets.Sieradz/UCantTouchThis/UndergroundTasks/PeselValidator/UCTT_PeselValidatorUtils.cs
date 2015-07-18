using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Toci.Hornets.Sieradz.UCantTouchThis.UndergroundTasks.PeselValidator
{
    public static class UCTT_PeselValidatorUtils
    {
        private const int MonthLowerBoundary = 0;
        private const int MonthUpperBoundary = 13;
        private const int MonthIndex = 0;
        private const int YearIndex = 0;
        private static readonly int[] PeselWages = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 1 };


        private static readonly Dictionary<int[], Func<int,int>> DayMap = new Dictionary<int[], Func<int, int>>()
        {
            {new []{1,3,5,7,8,10,12}, x => 31},
            {new []{4,6,9,11}, x => 30},
            {new []{2}, year => (IsYearLeap(year) ? 29 : 28)}
        };

        private static readonly Dictionary<Func<int, bool>, int[]> PeselDateModificatorsMap = new Dictionary<Func<int, bool>, int[]>
        {
            {month => month > 80, new[] {80, 1800}},
            {month => month > 60, new[] {60, 2200}},
            {month => month > 40, new[] {40, 2100}},
            {month => month > 20, new[] {20, 2000}},
            {month => month < 21, new[] {00, 1900}}
        };

        static bool IsYearLeap(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }

        static bool IsMonthValid(int month)
        {
            return month > MonthLowerBoundary && month < MonthUpperBoundary;
        }

        static bool IsDayValid(int day, int month, int year)
        {
            if (day < 1 || day > 31) return false;
            var key = DayMap.Keys.FirstOrDefault(x => x.Contains(month));
            return key != null && day <= DayMap[key].Invoke(year);
        }

        public static bool IsDateValid_SlowAndLameVersion(int day, int month, int year)
        {
            DateTime date;
            return DateTime.TryParse(month + "/" + day + "/" + year, CultureInfo.CreateSpecificCulture("en-US"), DateTimeStyles.None, out date);
//            return DateTime.TryParse(month + "/" + day + "/" + year, out date);
        }

        public static bool IsDateValid(int day, int month, int year)
        {
            return IsMonthValid(month) && IsDayValid(day, month, year);
        }

        public static bool IsChecksumOk(char[] peselArray)
        {
            int checksum = 0;
            for (int i = 0; i < peselArray.Length; i++)
                checksum += (peselArray[i] - 48) * PeselWages[i];
            return (checksum % 10) == 0;
        }

        public static void GetDateFromPesel(char[] peselArray, int[] dateArray)
        {
            dateArray[0] = (peselArray[0] - '0') * 10 + (peselArray[1] - '0'); //year
            dateArray[1] = (peselArray[2] - '0') * 10 + (peselArray[3] - '0'); //month
            dateArray[2] = (peselArray[4] - '0') * 10 + (peselArray[5] - '0'); //day
        }

        public static bool ValidateDate(int year, int month, int day)
        {
            var normalizedPeselDate = NormalizePeselDate(month, year);
            return IsDateValid(day, normalizedPeselDate[MonthIndex], normalizedPeselDate[YearIndex]);
        }

        private static int[] NormalizePeselDate(int month, int year)
        {
            var peselDateModificators =
                PeselDateModificatorsMap.FirstOrDefault(item => item.Key(month)).Value;
            return new [] {month - peselDateModificators[MonthIndex], year + peselDateModificators[YearIndex]};
        }
    }
}