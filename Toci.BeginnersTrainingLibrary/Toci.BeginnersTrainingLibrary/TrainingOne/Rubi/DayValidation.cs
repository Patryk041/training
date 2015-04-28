﻿using Toci.BeginnersTrainingLibrary.TrainingOne.Rubi.Interfaces;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Rubi
{
    public class DayValidation : IDayValidation
    {


        private const int MinDay = 0;
        private const int LongMonthLastDay = 31;
        private const int ShortMonthLastDay = 30;
        private const int LongFebruaryLastDay = 29;
        private const int ShortFebruaryLastDay = 28;


        public bool VerifyLongMonthDay(int day)
        {

            return day > MinDay && day <= LongMonthLastDay;

        }

        public bool VerifyShortMonthDay(int day)
        {
            return day > MinDay && day <= ShortMonthLastDay;
        }

        public bool VerifyLongFebruaryDay(int day)
        {
            return day > MinDay && day <= LongFebruaryLastDay;
        }


        public bool VerifyShortFebruaryDay(int day)
        {
            return day > MinDay && day <= ShortFebruaryLastDay;
        }
    }
}
