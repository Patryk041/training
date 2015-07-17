using System.Collections.Generic;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.GhostRider.Kir.GhostRiderSolution;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Didi;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Didi.Banki;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Hipek;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe
{
    public class HandlersGenerator : GenericGenerator<TransferHandle>
    {
        public HandlersGenerator()
        {
            GenericElementsDictionary = new Dictionary<string, List<TransferHandle>>
            {
                {  "Gliwice", new List<TransferHandle>()
                    {
                        new DidiInnyBank(),
                        new DidiINGBank(),
                        new DidiPKOBank()
                        new HipekTransferHandle()
                    }
                }
            };
        }
    }
}