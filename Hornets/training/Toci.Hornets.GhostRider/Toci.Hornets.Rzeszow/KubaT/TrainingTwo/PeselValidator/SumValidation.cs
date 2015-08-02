using System;
using System.Collections.Generic;

namespace Toci.Hornets.Rzeszow.KubaT.TrainingTwo.PeselValidator
{
    public class SumValidation
    {
        public static int[] StringToArray(string pesel)
        {
            int[] peselArray = new int[pesel.Length];
            for (var index = pesel.Length - 1; index >= 0; index--)
            {
                var partOfString = pesel.Substring(index, 1);
                int partOfArray = Convert.ToInt32(partOfString);
                peselArray[index] = partOfArray;
            }
            return peselArray;

        }
        public static bool IsValid(string pesel)
        {
            int value = 0;
            int[] currentPeslelArray = StringToArray(pesel);
            var weight = new List<int> {1, 3, 7, 9, 1, 3, 7, 9, 1, 3};
            for (var index = weight.Count - 1; index >= 0; index--)
            {
                value += weight[index]*currentPeslelArray[index];
            }
            value = value % 10;
            value = 10 - value;
            if (value == currentPeslelArray[11])
            {
                return true;
            }
            return false;
        }
    }
}