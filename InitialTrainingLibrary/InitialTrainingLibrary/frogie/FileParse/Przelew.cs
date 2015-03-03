using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.frogie.FileParse
{
    public class Przelew
    {
        public string Account { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Date { get; set; }
        public string Cash { get; set; }
        public string Address { get; set; }

        public List<Przelew> GetTransfers()
        {
            File file = new File();

            var result = file.PodajDaneZPliku();
            var slownik = file.PodajDaneZLinii(result);
            List<Przelew> wynik = new List<Przelew>();

            foreach (var item in slownik)
            {
                var przelew = new Przelew();

                przelew.Account = item.Value[0];
                przelew.Address = item.Value[5];

                wynik.Add(przelew);
            }

            return wynik;
        }
    }
}
