using System.Collections.Generic;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.GhostRider.Kir.GhostRiderSolution;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Hipek;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.MoWerr;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.PiotrekJ;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Rudi;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Soltys;

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

                        new HipekBankTransferParser(),
                        new PiotrekJBankTransferParser(),
                        new MoWerrBankTransferParser(),

                        new SoltysBankTransferParser(),
                        new HipekBankTransferParser()

                    }
                }
            };
        }
    }
}