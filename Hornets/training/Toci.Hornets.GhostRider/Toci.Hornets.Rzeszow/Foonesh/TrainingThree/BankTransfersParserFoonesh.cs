using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Rzeszow.Foonesh.TrainingThree
{
    class BankTransfersParserFoonesh:BankTransfersParser
    {
        public override List<BankTransfer> GetBankTransfers()
        {
            List<BankTransfer> bankTransferList = new List<BankTransfer>();
            string bankTransfers = BankFileOperation.GetFileContent("C:\test");
            foreach (String s in bankTransfers.Split())
            {
                bankTransferList.Add(GetTransferEntry(s));
            }
            return bankTransferList;
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            BankTransfer bankTransfer = new BankTransfer();
            bankTransfer.SourceBank = entry.Split(';')[0];
            bankTransfer.DestinationBank = entry.Split(';')[1];
            return bankTransfer;
        }
    }
}
