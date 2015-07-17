using System;
using System.Collections.Generic;
using System.Linq;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Legnica.Patryk_Stulczewski.Utils;
using Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.TransferHandles;

namespace Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.Factories
{
    public class TransferHandleFactory : GenericFactory<string,Func<TransferHandle>>
    {
        public TransferHandleFactory()
        {
            GenericDictionary = new Dictionary<string, Func<TransferHandle>>()
            {
                {"Pekao", () => new PekaoTransferHandle()},
                {"Nordea",() => new NordeaTransferHandle()},
                {"Bzwbk", () => new BzwbkTransferHandle()},
                {"Ing", () => new IngTransferHandle()}
            };
        }

        public IEnumerable<TransferHandle> GetAllHandles()
        {

            return GenericDictionary.Keys.Select(key => GenericDictionary[key]()).ToList();
        }

        public TransferHandle GetTransferHandleByBankName(string bankName)
        {
            return GenericDictionary.ContainsKey(bankName) ? GenericDictionary[bankName]() : null;
        }

        public IEnumerable<TransferHandle> GetTransfersByPredicate(Func<string,bool> predicate)
        {
            return (from key in GenericDictionary.Keys where predicate(key) select GenericDictionary[key]()).ToList();
        }
    }
}