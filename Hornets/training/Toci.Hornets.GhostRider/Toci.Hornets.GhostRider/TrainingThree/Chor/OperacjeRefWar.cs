namespace Toci.Hornets.GhostRider.TrainingThree.Chor
{
    public class OperacjeRefWar
    {
        public void Referencyjne(WorekNaDane worek)
        {
            // worek to kopia referencji do obiektu
            worek.Liczba = 8;

            worek.MniejszyWorekNaDane = new MniejszyWorekNaDane();

            worek.MniejszyWorekNaDane.NumerKonta = "1234";

            // worek = '0xFDSAGSDGWR$#!%#@!TEFDDGSSDF'
            // operacja ponizej kasuje poprzedni adres i robi nowy
            //worek = new WorekNaDane();

            //worek.Liczba = 9;

            //DalejReferencyjneAkaChor(worek);
        }

        public void DalejReferencyjneAkaChor(WorekNaDane worek)
        {
            var test = worek.Liczba;  /// ??? 8  0 ???? 8 !
                                      /// 
            var test2 = worek.MniejszyWorekNaDane.NumerKonta;// 1234 

            worek.MniejszyWorekNaDane = new MniejszyWorekNaDane();

        }

        public void ReferencyjneEtap3(WorekNaDane worek)
        {
            var test2 = worek.MniejszyWorekNaDane.NumerKonta; // 1234 vs ''
        }

        public void AleZeMnieDebil()
        {
            WorekNaDane worek = new WorekNaDane();

            Referencyjne(worek);
            DalejReferencyjneAkaChor(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
            ReferencyjneEtap3(worek);
        }

        public void Wartosciowe(int test)
        {
            test = 7;

            //WartoscioweDalszyTest(test);
        }

        public void WartoscioweDalszyTest(int test)
        {
            var ile = test; /// ??? 

            test = 5;
        }

        public void AleZEmnieDebil()
        {
            int test = 0;

            Wartosciowe(test);
            WartoscioweDalszyTest(test);
        }
    }
}