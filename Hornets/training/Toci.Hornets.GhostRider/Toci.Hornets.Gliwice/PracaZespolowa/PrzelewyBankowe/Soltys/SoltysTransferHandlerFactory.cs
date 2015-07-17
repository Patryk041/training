using System.Collections.Generic;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Soltys.Banks;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Soltys
{
    static class SoltysTransferHandlerFactory
    {
        private static readonly Dictionary<string, TransferHandle> _transferHandlerDictionary = new Dictionary<string, TransferHandle>
        {
            {"ING", new SoltysIngBankTransferHandle()},
            {"PKO", new SoltysPkoBankTransferHandle()}
        };

        public static TransferHandle GetValidTransferHandler(string bankName)
        {
            if (_transferHandlerDictionary.ContainsKey(bankName))
            {
                return _transferHandlerDictionary[bankName];
            }

            return null;
        }
    }
}
