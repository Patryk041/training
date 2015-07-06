using System;
using System.Linq;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
using Toci.Hornets.Sieradz.UCantTouchThis.UndergroundTasks.PeselValidator;

namespace Toci.Hornets.Sieradz.UCantTouchThis.TasksTrainingTwo
{
    public class UCantTouchThisPeselValidator : PeselValidator
    {
        //Not final
        private readonly int[] _wages = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 1 };

        private int _day, _month, _year;

        public override bool IsPeselValid(string pesel)
        {
            if (!ArePeselDigitsOk(pesel)) return false;
            ExtractDate(CutOffDate(pesel));
            if (!ValidateDate(_year, _month, _day)) return false;
            return Checksum(pesel);
        }

        private bool ArePeselDigitsOk(string pesel)
        {
            var numberOfDigits = pesel.Count(Char.IsNumber);
            return numberOfDigits == 11 || pesel.Length != 11;
        }

        protected override string CutOffDate(string pesel)
        {
            return pesel.Substring(0, 6);
        }

        private void ExtractDate(string dateString)
        {
            Int32.TryParse(dateString.Substring(0, 2), out _year);
            Int32.TryParse(dateString.Substring(2, 2), out _month);
            Int32.TryParse(dateString.Substring(4, 2), out _day);            
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            SetMonthAndYear(ref year, ref month);
            return UCTT_DateValidatorUtils.IsDateValid(day, month, year);
        }

        protected override bool Checksum(string pesel)
        {
            int checksum = pesel.Select((t, i) => t * _wages[i]).Sum();
            return (checksum % 10) == 0;
        }

        private void SetMonthAndYear(ref int year, ref int month)
        {
            //  TODO: Get rid of those ifs
            if (month > 80)
            {
                month -= 80;
                year += 1800;
            }
            else if (month > 60)
            {
                month -= 60;
                year += 2200;
            }
            else if (month > 40)
            {
                month -= 40;
                year += 2100;
            }
            else if (month > 20)
            {
                month -= 20;
                year += 2000;
            }
            else
            {
                year += 1900;
            }
        }

        public override string GetNick()
        {
            return "UCantTouchThis";
        }
    }
}