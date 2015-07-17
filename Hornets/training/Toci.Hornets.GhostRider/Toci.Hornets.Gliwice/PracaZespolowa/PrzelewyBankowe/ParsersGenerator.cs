using System.Collections.Generic;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.GhostRider.Kir.GhostRiderSolution;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Hipek;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Rudi;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe
{
    public class ParsersGenerator : GenericGenerator<BankTransfersParser>
    {
        public ParsersGenerator()
        {
            GenericElementsDictionary = new Dictionary<string, List<BankTransfersParser>>
            {
                { "Gliwice", new List<BankTransfersParser>
                    {
                        new DidiBankTransferParser(),
                        new RudiBankTransferParser(),
                        new HipekBankTransferParser()
                    }
                }
            };
        }
    }
}