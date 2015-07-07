using System;
using System.Collections.Generic;

namespace Toci.Hornets.Kalisz.Adrianowsky94.PeselValidatorHW.PeselManipulationMethods
{
    public class SumChecker
    {
        public static bool CheckSum(string pesel)
        {
            List<int> peselNumber = new List<int>();
            List<string> peselNumberStringList = new List<string>();

            foreach (Char number in pesel.ToCharArray())
            {
                peselNumberStringList.Add(number.ToString());
            }

            peselNumberStringList.ToArray();

            foreach (var number in peselNumberStringList)
            {
                peselNumber.Add(Convert.ToInt32(number));
            }

            peselNumber.ToArray();

            int sum =
                1*peselNumber[0] +
                3*peselNumber[1] +
                7*peselNumber[2] +
                9*peselNumber[3] +
                1*peselNumber[4] +
                3*peselNumber[5] +
                7*peselNumber[6] +
                9*peselNumber[7] +
                1*peselNumber[8] +
                3*peselNumber[9];

                sum %= 10;
                sum = 10 - sum;
                sum %= 10;

            return sum == peselNumber[10];
        }
    }
}