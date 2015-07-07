using System;

namespace Toci.Hornets.Rzeszow.Chojnecki.TrainingTwoPESEL
{
    internal class PeselControler
    {
        //Cyfra kontrolna i sprawdzanie poprawności numeru


        public static bool PeselContor(string pesel)
        {
            var peselInt = Array.ConvertAll(pesel.ToCharArray(), c => (int) char.GetNumericValue(c));
            var peselTest = 1*peselInt[0] + 3*peselInt[1] + 7*peselInt[2] + 9*peselInt[3] + 1*peselInt[4] +
                            3*peselInt[5]
                            + 7*peselInt[6] + 9*peselInt[7] + 1*peselInt[8] + 3*peselInt[9];
            peselTest = peselTest%10;
            if (peselTest == 10)
            {
                return (peselInt[10] == 0);
            }
            return (peselInt[10] == 10 - peselTest);
        }
    }
}