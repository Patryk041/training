using System.Collections.Generic;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Sieradz.SieradzBankTransferTask.Alior
{
    public class UCantTouchThisBankTransfersParser : BankTransfersParser
    {
        public UCantTouchThisBankTransfersParser()
        {
            BankFileOperation = new SieradzFileOperation();
        }

        public override List<BankTransfer> GetBankTransfers()
        {
            var bankTransferList = new List<BankTransfer>();
            var file = BankFileOperation.GetFileContent(SieradzBankFilesPathHolder.TransferFilesPath + "Alior.json");
            var lines = file.Split('\n');
            foreach (var line in lines)
            {
                bankTransferList.Add(GetTransferEntry(line));
            }
            return bankTransferList;
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            BankTransfer bankTransfer = new SieradzBankTransfer();

            return bankTransfer;
        }
    }
}