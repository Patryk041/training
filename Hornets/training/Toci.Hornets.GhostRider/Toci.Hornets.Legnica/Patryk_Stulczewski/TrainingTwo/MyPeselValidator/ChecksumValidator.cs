using Toci.Hornets.Legnica.Patryk_Stulczewski.TrainingTwo.Interfaces;

namespace Toci.Hornets.Legnica.Patryk_Stulczewski.TrainingTwo.MyPeselValidator
{
    public class ChecksumValidator : IChecksumValidator
    {
        public bool ValidateChecksum(string str)
        {
            int checksum = GenereteChecksum(str.Substring(0, str.Length - 1)); 
            int last = int.Parse(str[str.Length - 1].ToString());
            return checksum % 10 != 0 ? (10 - checksum % 10) == last : 0 == last;
        }

        private int GenereteChecksum(string str)
        {
            int checksum = 0, multiplier = 1;
            foreach (var sign in str)
            {
                checksum += (int.Parse(sign.ToString()) * multiplier);
                multiplier = multiplier == 3 ? (multiplier + 4) % 10 : (multiplier + 2) % 10;
            }
            return checksum;
        }
    }
}