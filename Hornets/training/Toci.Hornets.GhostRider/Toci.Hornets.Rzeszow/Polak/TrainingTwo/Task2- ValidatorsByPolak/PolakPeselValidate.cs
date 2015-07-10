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
            var suma = PeselArray[0] + 3 * PeselArray[1] + 7 * PeselArray[2] + 
                       9 * PeselArray[3] + PeselArray[4] + 3 * PeselArray[5] + 
                       7 * PeselArray[6] + 9 * PeselArray[7] + PeselArray[8] + 
                       3 * PeselArray[9];

            int isPeselOk;
            if (suma % 10 == 0) isPeselOk = 0;
            else
            {
                isPeselOk = 10 - (suma % 10);
            }

            return (isPeselOk == PeselArray[10]);
        

        }

    

        protected override bool ValidateDate(int year, int month, int day)
        {
            return true;
        }

        public override string GetNick()
        {
            return "Polak";
        }

        public override bool IsPeselValid(string pesel)
        {
            return true;
            //nie zdazyłem więcej :(
        }
    }
}