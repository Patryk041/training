using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.dysq.DateValidator.Days;
using InitialTrainingLibrary.Interfaces;

namespace InitialTrainingLibrary.dysq.DateValidator
{
    public class MyDate : IDateValidator
    {

        public bool DateValidate(int year, int month, int day)
        {
        
            if (IsMonthValid(month))
            {
                if (IsDayValidOf31(day) && Months.GetMonths31Days().Any(_month => _month == month))
                    return true;

                if (IsDayValidOf30(day) && Months.GetMonths30Days().Any(_month => _month == month))
                    return true;
                
                if (IsDayValidOf28(day))
                    return Months.Is28DaysMonth(month);   
            }

            return false;
        }

        public string GetName()
        {
            return "Dysq";
        }


        private bool IsMonthValid(int month)
        {
            return Months.IsMonthCorrect(month);
        }

        private bool IsDayValidOf31(int day)
        {
            return Days31ofMonths.IsCorrect(day);
        }

        private bool IsDayValidOf30(int day)
        {
            return Days30ofMonths.IsCorrect(day);
        }

        private bool IsDayValidOf28(int day)
        {
            return Days28ofMonth.IsCorrect(day);
        }
    }
}
