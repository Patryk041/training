using System;
using System.Linq;

namespace Toci.Hornets.Sieradz.Jake.TrainingTwo.PeselValidator.tools
{
    public class PeselChecksum
    {
       public bool IsCorrect(string pesel)
        {
            int[] myPesel = pesel.Select(s => Convert.ToInt32(s)).ToArray();

            int[] peselVages = {1, 3, 7, 9, 1, 3, 7, 9, 1, 3};
            
            int sum = 0;
            int validateNo = myPesel[10];

            for(int i = 0; i<10; i++)
            {
                sum += myPesel[i] * peselVages[i];
            }

            int checkSum = (10 - sum % 10) % 10;

            return checkSum == validateNo;
        }
    }
}