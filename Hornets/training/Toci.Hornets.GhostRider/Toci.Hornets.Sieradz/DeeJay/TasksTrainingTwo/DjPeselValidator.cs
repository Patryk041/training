using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Sieradz.DeeJay.TasksTrainingTwo
{
    public class DjPeselValidator : PeselValidator
    {
        private static readonly int[] Vages = {1, 3, 7, 9, 1, 3, 7, 9, 1, 3};

        private static readonly SortedList<int, int> Stulecia = new SortedList<int, int>
            {
                { 20, 1900 },
                { 40, 2000 },
                { 60, 2100 },
                { 80, 2200 },
                { 100, 1800 }
            };

        protected override string CutOffDate(string pesel)
        {
            return pesel.Substring(0,6);
        }

        protected override bool Checksum(string pesel)
        {
            var sum = 0;
            var controlNo = int.Parse(pesel.Substring(10, 1));

            for(var i=0; i<pesel.Length-1; i++)
            {
                sum += int.Parse(pesel.Substring(i, 1)) * Vages[i];
            }

            var checkSum = (10 - sum%10) %10;

            return checkSum == controlNo;
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            year += Stulecia.First(x => x.Key > month).Value;
            month -= (Stulecia.First(x => x.Key > month).Key - 20);

            var dateString = year + "-" + month + "-" + day;
            DateTime dateOfBirth;

            return DateTime.TryParse(dateString, out dateOfBirth) && dateOfBirth <= DateTime.Today;
        }

        public override string GetNick()
        {
            return "DeeJay";
        }

        public override bool IsPeselValid(string pesel)
        {
            if (string.IsNullOrEmpty(pesel) || !IsExactlyElevenDigitsInPesel(pesel))
            {
                return false;
            }

            var dateString = CutOffDate(pesel);
            var year = int.Parse(dateString.Substring(0, 2));
            var month = int.Parse(dateString.Substring(2, 2));
            var day = int.Parse(dateString.Substring(4, 2));

            return Checksum(pesel) && ValidateDate(year, month, day);
        }

        private static bool IsExactlyElevenDigitsInPesel(string pesel)
        {
            var elevenDigitsRegex = new Regex(@"^\d{11}$");
            return elevenDigitsRegex.IsMatch(pesel);
        }
    }
}