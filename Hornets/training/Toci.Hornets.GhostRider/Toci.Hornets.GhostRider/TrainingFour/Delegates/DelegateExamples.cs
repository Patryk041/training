using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.GhostRider.TrainingFour.Delegates
{
    public class DelegateExamples
    {
        public static object cos;

        public delegate void Whatever(string test1, PerformTransfers trf);

        private int wartosc = 5;
        public void Test()
        {
            Whatever wtf = Delegowanie;

            wtf += Cokolwiekinnego;

            PerformTransfers trf = null;

            lock (cos)
            {
                wtf("ogarnij sie", trf);
            }
        }

        public void Delegowanie(string test, PerformTransfers tfs)
        { //2
            var sprawdz = this.wartosc;

            tfs.TransferAll();

            return ;
        }

        public void Cokolwiekinnego(string gfsda, PerformTransfers fdsa)
        {
            
        }
    }
}