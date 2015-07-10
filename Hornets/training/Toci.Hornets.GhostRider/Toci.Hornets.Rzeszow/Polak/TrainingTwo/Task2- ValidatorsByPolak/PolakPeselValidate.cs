using System.Linq;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Rzeszow.Polak.TrainingTwo

{
    public class PolakPeselValidate : PeselValidator
    {
        

        protected override string CutOffDate(string pesel)
        {
            return pesel.Substring(0, 6);
        }

        protected override bool Checksum(string pesel)
        {
            int[] PeselArray = new int[pesel.Length];
            for (int i = 0; i < pesel.Length; i++)
            {
                PeselArray[i] = int.Parse(pesel.ElementAt(i).ToString());
            }
            var sum = PeselArray[0] + 3 * PeselArray[1] + 7 * PeselArray[2] + 9 * PeselArray[3]
                      + PeselArray[4] + 3 * PeselArray[5] + 7 * PeselArray[6] + 9 * PeselArray[7]
                      + PeselArray[8] + 3 * PeselArray[9];

            int IsPeselOk;
            if (sum % 10 == 0) IsPeselOk = 0;
            else
            {
                IsPeselOk = 10 - (sum % 10);
            }

            return (IsPeselOk == PeselArray[10]);
        

        }

        private void elseif(bool p)
        {
            throw new System.NotImplementedException();
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            throw new System.NotImplementedException();
        }

        public override string GetNick()
        {
            return "Polak";
        }

        public override bool IsPeselValid(string pesel)
        {
            throw new System.NotImplementedException();
        }
    }
}