using System.Collections.Generic;
using System.Linq;
using Toci.Hornets.GhostRider.GhostRider;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.GhostRider.TrainingFour.Linq
{
    public class LinqShowdown
    {
        public void RunLinqs()
        {
            IEnumerable<int> tablica = new int[] {2, 4, 3, 5, 2, 3};

            var lista = tablica.ToList(); // gen lista 
            // List<int>

            int[] tabOfInts = {1, 2, 3, 1, 5, 4, 3};

            int sum = tabOfInts.Sum(); // 19

            var result = lista.Where(item => item == 3);// 2

            lista.Add(3);
            lista.Add(3);
            lista.Add(3);
            lista.Add(3);
            lista.Add(3);


            var icoteraz = result.ToArray();

            var ile = icoteraz.Length; // 7 !!!!

            lista.Add(3);

            var final = result.ToArray();

            Dictionary<string, string> klienci = new Dictionary<string, string>
            {
                { "30102061274627621478132", "Jas wedrowniczek"},
                { "30105061274627621478132", "Jas fasola"},
                { "30103061274627621478132", "johnny english"},
                { "30107061274627621478132", "jan kowalski"},
            };

            Dictionary<string, string> banki = new Dictionary<string, string>
            {
                { "1020", "Ing"},
                { "1030", "Pko"},
                { "1040", "nordea"},
                { "1050", "mbank"},
            };

            var chosenbank = banki.Where(item => item.Value == "mbank").Select(item => new MyExampleOfHomework());//string.Format("{0} to kod banku {1}", item.Key, item.Value));

            //banki.Add("1020", "dsfsdfasd");
            banki.Add("1060", "bzwbk");

            //IEqualityComparer<string> dsa;

            //dsa.

            var jazda = chosenbank.ToArray();
            //  nr konta , nazwa banku, klient
            var wynik = klienci.Join(
                banki,
                klienciSelector => klienciSelector.Key.Substring(2, 4),
                bankiSelector => bankiSelector.Key,
                (klient, bank) => new BankTransfer {Konto = klient.Key, NazwaBanku = bank.Value, Klient = klient.Value});

            var testhaha = wynik.Count();

            klienci.Add("121111", "szyfrant");


        }
    }
}