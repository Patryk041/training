
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;


namespace Toci.Hornets.Rzeszow.KSebal.traning2Homework.Pesel
{
    public class KsebalPeselValidator:PeselValidator
    {
        private PeselDate data;
                                    



        protected override string CutOffDate(string pesel)
        {
            return pesel.Substring(0,6);

            
        }

        protected override bool Checksum(string pesel)
        {
            return new PeselSumValidator(pesel).checkPesel();
           
        }

        public bool test(string pesel)
        {
            return Checksum(pesel);
        }
        protected override bool ValidateDate(int year, int month, int day)
        {
            return data.ValidateDate(year,month,day);
        }

        public override string GetNick()
        {
            return "Ksebal";
        }

        public override bool IsPeselValid(string pesel)
        {
            data = new PeselDate(CutOffDate(pesel));
            return Checksum(pesel) && ValidateDate(data.year,data.month,data.day);
        }
    }
}
