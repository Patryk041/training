using System.Collections.Generic;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Rzeszow.Terry.TrainingThree.TerryBank;

namespace Toci.Hornets.Rzeszow.Terry.TrainingThree.Common
{
    public static class RzeszowHandlersFactory
    {
        private static readonly Dictionary<string, TransferHandle> HandleDictionary = new Dictionary<string, TransferHandle>
        {
            {"TerryBank", new TerryBankTransferHandle()},
        };
        public static TransferHandle GetHandle(string bank)
        {
            return HandleDictionary.ContainsKey(bank) ? HandleDictionary[bank] : null;
        }
    }
}