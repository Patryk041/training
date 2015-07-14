using System;
using System.Globalization;
using System.Text.RegularExpressions;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Sieradz.DeeJay.TasksTrainingTwo
{
    public class DjPeselValidator : PeselValidator
    {
        private readonly int[] vages = {1, 3, 7, 9, 1, 3, 7, 9, 1, 3};

        protected override string CutOffDate(string pesel)
        {
            return pesel.Substring(0,6);
        }

        protected override bool Checksum(string pesel)
        {
            var controlNo = 0;
            var sum = 0;

            if (!int.TryParse(pesel.Substring(10, 1), out controlNo))
            {
                return false;
            }

            for(int i=0; i<pesel.Length-1; i++)
            {
                var digit = 0;
                if (!int.TryParse(pesel.Substring(i, 1), out digit))
                {
                    return false;
                }
                sum += digit*vages[i];
            }

            var checkSum = (10 - sum%10) %10;

            return checkSum == controlNo;
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

            var dateString = year.ToString() + "-" + month.ToString() + "-" + day.ToString();
            DateTime dateOfBirth;
            if(!DateTime.TryParse(dateString, out dateOfBirth))
            {
                return false;
            }

            return dateOfBirth <= DateTime.Today;
        }

        public override string GetNick()
        {
            return "DeeJay";
        }

        public override bool IsPeselValid(string pesel)
        {
            if (String.IsNullOrEmpty(pesel) || !IsExactlyElevenDigitsInPesel(pesel))
            {
                return false;
            }

            var dateString = CutOffDate(pesel);
            var year = int.Parse(dateString.Substring(0, 2));
            var month = int.Parse(dateString.Substring(2, 2));
            var day = int.Parse(dateString.Substring(4, 2));

            return Checksum(pesel) && ValidateDate(year, month, day);
        }

        private bool IsExactlyElevenDigitsInPesel(string pesel)
        {
            Regex elevenDigitsRegex = new Regex(@"^\d{11}$");
            return elevenDigitsRegex.IsMatch(pesel);
        }
    }
}