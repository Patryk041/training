using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces;

namespace InitialTrainingLibrary.hipek._1.DateValidator
{
    public static class DateValidatorFactory
    {
        
        private static Dictionary<int , Func<IDateValidator>> validatorMap = new Dictionary
            <int, Func<IDateValidator>>()
        {
            {1, () => new _31thMonthsValidator()},
            {2, () => new LeapYear()},
            {3, () => new _31thMonthsValidator()},
            {4, () => new _30thMonthsValidator()},
            {5, () => new _31thMonthsValidator()},
            {6, () => new _30thMonthsValidator()},
            {7, () => new _31thMonthsValidator()},
            {8, () => new _31thMonthsValidator()},
            {9, () => new _30thMonthsValidator()},
            {10, () => new _31thMonthsValidator()},
            {11, () => new _30thMonthsValidator()},
            {12, () => new _31thMonthsValidator()},
        };

        private static Dictionary<bool, Func<IDateValidator>> validatorLeapYear = new Dictionary
            <bool, Func<IDateValidator>>()
        {
            {false, () => new _28thMonthsValidator()},
            {true, () => new _29thMonthsDateValidator()},
        };

        public static IDateValidator CreateDateValidator(int month)
        {
            return validatorMap[month]();       
        }

        public static IDateValidator CreateLeapYearValidator(bool IfLeapYear)
        {
            return validatorLeapYear[IfLeapYear]();
        }
    }
}
