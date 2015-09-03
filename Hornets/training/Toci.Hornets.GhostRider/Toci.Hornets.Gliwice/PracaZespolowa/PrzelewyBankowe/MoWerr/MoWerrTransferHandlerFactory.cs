using System.Collections.Generic;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.MoWerr.Banks;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.MoWerr
{
    public class MoWerrTransferHandlerFactory
    {
         private static readonly Dictionary<string, TransferHandle>  TransferHAndlersDictionary = new Dictionary<string, TransferHandle>
         {
             {"mBank", new MoWerrMBankTransferHandle()},
             {"PKO", new MoWerrPKOBankTransferHandle()}
         };

        public static TransferHandle GetTransferHandler(string destinationBank)
        {
            return TransferHAndlersDictionary.ContainsKey(destinationBank) ? TransferHAndlersDictionary[destinationBank] : null;
        }
    }
}