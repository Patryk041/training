using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Rzeszow.Foonesh.TrainingThree
{
    public class BankTransfersParserFoonesh:BankTransfersParser
    {
        public override List<BankTransfer> GetBankTransfers()
        {
            BankFileOperation = new FileOperationFoonesh();
            List<BankTransfer> bankTransferList = new List<BankTransfer>();
            string bankTransfers = BankFileOperation.GetFileContent(@"D:\Szkolenie C#\Code\Hornets\training\Toci.Hornets.GhostRider\Toci.Hornets.Rzeszow\Foonesh\TrainingThree\TransferData\TransferOne.txt");
            foreach (String s in bankTransfers.Split('\n'))
            {
                bankTransferList.Add(GetTransferEntry(s));
            }
            return bankTransferList;
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            BankTransfer bankTransfer = new BankTransfer
            {
                SourceBank = entry.Split(';')[0],
                DestinationBank = entry.Split(';')[1]
            };
            return bankTransfer;
        }
    }
}
