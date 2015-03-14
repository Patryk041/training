using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Utils;

namespace InitialTrainingLibrary.TrainingFour.Linq
{
    public class WarriorLinqOperations
    {
        public void TestLinqArray()
        {
            string[] test1 = new[] {"zaba", "chmura", "koziu", "dysq"};

            var result = test1.Where(ChmuraNieUmie);

            test1[3] = "nowa";

            var patrzcie = result.ToArray();
        }

        private bool ChmuraNieUmie(string test)
        {
            return test.WarriorIsAnagram("raumch");
        }

        public void TestLinqDictionary()
        {
            var slownik = new Dictionary<string, string>()
            {
                { "zaba", "wartosc1"},
                { "chmura", "wartosc2"},
                { "koziu", "wartosc"},
                { "dysq", "wartosc"},
                { "mg", "wartosc5"},
            };

            var koziu = slownik.Where(item => item.Value.Contains("wart") && item.Key.Contains("koz")).Where(item => item.Key.Contains("koziu"));

            var dysq = slownik.Where(item => item.Key.Contains("dys"));


            var mg = dysq.Select(item => item.Value);

            var dysqjoin = dysq.Join(mg, item => item.Value, item => item, (item, item2) => (item.Key + "_" + item2));


            var zabachcejoina = koziu.Join(dysq, item => item.Value, item => item.Value, (item, item2) => (item.Key + "_" + item2.Key));

        }
    
    }
}
