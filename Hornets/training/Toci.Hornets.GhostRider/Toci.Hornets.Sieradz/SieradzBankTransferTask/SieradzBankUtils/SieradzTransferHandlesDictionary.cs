using System.Collections.Generic;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Sieradz.UCantTouchThis.ExtensionMethods;

namespace Toci.Hornets.Sieradz.SieradzBankTransferTask.SieradzBankUtils
{
    public static class SieradzTransferHandlesDictionary
    {
         private static Dictionary<string, TransferHandle> _transferHandlesDictionary = new Dictionary<string, TransferHandle>();

         private const string fieldName = "BankName";

        public static void InitialiseTransferHandleDictionaty(List<TransferHandle> transferHandlesList)
        {
            foreach (var transferHandle in transferHandlesList)
            {
                var key = (string) transferHandle.GetProtectedFieldValue(fieldName);
                if (!_transferHandlesDictionary.ContainsKey(key))
                    _transferHandlesDictionary.Add(key, transferHandle);
            }
        }

        public static TransferHandle GetTransferHandleByBankName(string bankName)
        {
            return (_transferHandlesDictionary.ContainsKey(bankName)) ? _transferHandlesDictionary[bankName] : null;
        }

    }
}