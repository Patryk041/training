using System;
using System.Collections.Generic;
using System.Linq;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Legnica.Michał_Zembik.FTPcs;
using Toci.Hornets.Legnica.Patryk_Stulczewski.Utils;
using Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.BankTransfersParsers;
using Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.TransferHandles;

namespace Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.Factories
{
    public class BankTransfersParserFactory : GenericFactory<string,Func<BankTransfersParser>>
    {
        public BankTransfersParserFactory()
        {
            GenericDictionary = new Dictionary<string, Func<BankTransfersParser>>()
            {
               {"Pekao", () => new PekaoBankTransfersParser() },
               {"Nordea",() => new NordeaBankTransfersParser(new LegnicaFileOperation())},
               {"Bzwbk", () => new BzwbkBankTransfrsParser()},
               {"Ing", () => new IngBankTransfersParser()}
            };
        }

        public IEnumerable<BankTransfersParser> GetAllParsers()
        {
            return GenericDictionary.Keys.Select(key => GenericDictionary[key]()).ToList();
        }
    }
}