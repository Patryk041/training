using System;
using System.Collections.Generic;
using Toci.Hornets.GhostRider.TrainingTwo.DllShowdown;
using Toci.Hornets.GhostRider.TrainingTwo.ExtensionMethods;
using Toci.Hornets.GhostRider.TrainingTwo.Generics.Collections;

namespace Toci.Hornets.GhostRider.TrainingTwo.Generics
{
    public class TestGenerics
    {
        public void TestWtf()
        {
            //GenericCollection<int> ints = new GenericCollection<int>();
            //GenericCollection<string> strings = new GenericCollection<string>();
            GenericCollection<KlasaZBanki> KlasaZBankis = new GenericCollection<KlasaZBanki>();

            //ints.AddItem(2);
            //strings.AddItem("dhsgafds");

            Dictionary<string, int> slownik = new Dictionary<string, int>()
            {
                {"frogie", 34214},
                //{"frogie", 34214},
                {"szyfrqnt", 1},
            };

            Dictionary<KlasaZBanki, IFrogie> dsa = new Dictionary<KlasaZBanki, IFrogie>();
            //Dictionary<Dictionary<Dictionary<string, int>, int>, IFrogie> dsa = new Dictionary<KlasaZBanki, IFrogie>();

            //List<Func<bool>>
        }
    }
}