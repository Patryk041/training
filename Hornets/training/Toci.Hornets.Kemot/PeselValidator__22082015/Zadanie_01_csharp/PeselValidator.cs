using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_01_csharp
{
    public class PeselValidator
    {
        public static bool IsValidPESEL(string pesel)
        {
            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            bool result = false;
       
            if (pesel.Length == 11)
            {
                int sumControl = CalculateControlSum(pesel, weights);
                int numControl = sumControl % 10;
                numControl = 10 - numControl;
                if (numControl == 10)
                {
                    numControl = 0;
                }
                int lastDigit = int.Parse(pesel[pesel.Length - 1].ToString());
                result = numControl == lastDigit;
            }
            return result;
        } 

        private static int CalculateControlSum(string pesel, int[] weights)
        {
            int offset = 0;
            int sumControl = 0;
            for (int i = 0; i < pesel.Length - 1; i++)
            {
                sumControl += weights[i + offset] * int.Parse(pesel[i].ToString());
            }
            return sumControl;
        }
    }
}
