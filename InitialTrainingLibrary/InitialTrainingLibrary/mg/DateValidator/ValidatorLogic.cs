using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.mg.DateValidator
{
    internal class ValidatorLogic
    {
        private bool _isintercalary;


        public bool GetValidation(int year, int month, int day)
        {
            if (month == 2) _isintercalary = CheckInterCalar(year);
            return DoValidation(day, month);
        }

        private bool DoValidation(int day, int month)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            int[] days = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (_isintercalary) days[1] = 28;

            for (int i = 0; i < 12; i++)
            {
                dict.Add(i + 1, days[i]);
            }


            return dict.Keys.Contains(month) && day <= dict.Values.ElementAt(month - 1);

        }

        private bool CheckInterCalar(int year)
        {
            return ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);
        }
    }
}
