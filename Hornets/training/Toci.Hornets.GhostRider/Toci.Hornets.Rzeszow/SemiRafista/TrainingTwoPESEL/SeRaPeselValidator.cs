using System.Linq;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Rzeszow.SemiRafista.TrainingTwoPESEL
{
    public class SeRaPeselValidator : PeselValidator
    {
        protected override string CutOffDate(string pesel)
        {
            return pesel.Remove(6);
        }

        protected override bool Checksum(string pesel)
        {
            int[] peselInt = new int[pesel.Length];
            for (int i = 0; i < pesel.Length; i++)
            {
                peselInt[i] = int.Parse(pesel.ElementAt(i).ToString());
            }
            var sum = peselInt[0] + 3*peselInt[1] + 7*peselInt[2] + 9*peselInt[3]
                      + peselInt[4] + 3*peselInt[5] + 7*peselInt[6] + 9*peselInt[7]
                      + peselInt[8] + 3*peselInt[9];
            
            int peselTest;
            if (sum%10 == 0) peselTest = 0;
            else
            {
                peselTest = 10 - (sum%10);
            }

            return (peselTest == peselInt[10]);
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            SeRaDataValidator dataValidator = new SeRaDataValidator();
            return dataValidator.CheckDate(year, month, day);
        }

        public override string GetNick()
        {
            return "SemiRafista";
        }

        public override bool IsPeselValid(string pesel)
        {
            if (pesel.Length < 11)
                return false;
            if (Checksum(pesel) == false)
                return false;

            return ValidateDate(int.Parse(pesel.Substring(4, 2)), int.Parse(pesel.Substring(2, 2)), int.Parse(pesel.Substring(0, 2)));
        }   
    }
}