using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Rzeszow.Malwina.Pesell
{
    public class MalwiPeselValidator : PeselValidator
    {
        protected override string CutOffDate(string pesel)
        {
            return pesel.Substring(0, 6);
        }

        protected override bool Checksum(string pesel)
        {
            int[] tab = {1, 3, 7, 9, 1, 3, 7, 9, 1, 3};
            char[] peseltab = pesel.ToCharArray();
            int kontrol = 0;
            int check;
            for (int i = 0; i <= 10; i++)
            {
             kontrol =+ (tab[i]*peseltab[i]);
            }
           check = kontrol%10;
           if (check == 10)
           {
               return (peseltab[10] == 0);
           }
          
            return (peseltab[10] == check);
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            return DataCzyOk.Check(year, month, day);
        }

        public override string GetNick()
        {
            return "Malwi";
        }

        public override bool IsPeselValid(string pesel)
        {
            if (pesel.Length != 11) return false;
           
            if (Checksum(pesel) == false)  return false;

            var data = new DataCzyOk(CutOffDate(pesel));
            return ValidateDate(data.rok,data.miesiac,data.dzien);

        }
    }
}