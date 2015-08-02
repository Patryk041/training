using System.Collections.Generic;
using System.IO;


namespace Toci.Hornets.GhostRider.Kir
{
    public abstract class BankTransfersParser
    {
        protected FileOperation BankFileOperation;

        // wczytac plik do stringu
        // rozbic string na linie
        // linie przetworzyc GetTransferEntry na typ BankTransfer
        public abstract List<BankTransfer> GetBankTransfers();

        protected abstract BankTransfer GetTransferEntry(string entry);
    }
}