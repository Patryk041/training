using System;
using System.Linq;

namespace Toci.Hornets.Rzeszow.Chojnecki.TrainingTwoPESEL
{
    internal class PeselNumbersControler
    {
        //Cyfra kontrolna i sprawdzanie poprawności numeru
        public static bool PeselContor(string pesel)
        {
            int[] controlNumbers = {1, 3, 7, 9, 1, 3, 7, 9, 1, 3};
            var peselInt = Array.ConvertAll(pesel.ToCharArray(), c => (int) char.GetNumericValue(c));
            var peselTest = controlNumbers.Select((t, i) => t*peselInt[i]).Sum();
            peselTest = peselTest%10;
            if (peselTest == 10) return (peselInt[10] == 0);
            return (peselInt[10] == 10 - peselTest);
        }
    }
}