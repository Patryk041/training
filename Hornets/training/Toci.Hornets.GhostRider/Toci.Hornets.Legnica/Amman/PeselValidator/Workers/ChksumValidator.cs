using System;
using System.Collections.Generic;

namespace Toci.Hornets.Kalisz.Amman.PeselValidator.Workers
{
    public class ChksumValidator
    {
        static public bool Check(string psl)
        {
            if (psl.Length < 11) return false;
            var chksumProvided = psl.Substring(10, 1);
            var numbers = new int[10];

            
            for (var i = 0; i < 10; i++)
            {
                if (!int.TryParse(psl[i].ToString(), out numbers[i])) return false;
            }

            var weightsDictionary = new Dictionary<int, int>()
            {
                {0, 1},
                {1, 3},
                {2, 7},
                {3, 9},
                {4, 1},
                {5, 3},
                {6, 7},
                {7, 9},
                {8, 1},
                {9, 3},
            };
            var sum = 0;
            for (var i = 0; i < 10; i++)
            {
                sum += numbers[i]*weightsDictionary[i];
            }
            sum %= 10;
            if (sum != 0) sum = 10 - sum;
            return (sum.ToString() == chksumProvided);
        }
    }
}