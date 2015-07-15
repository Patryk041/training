using System.Collections.Generic;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Rzeszow.Terry.TrainingThree.TerryBank;

namespace Toci.Hornets.Rzeszow.Terry.TrainingThree.Bank
{
    public class TerryBankTransfersParser : BankTransfersParser
    {

        /* Format zapisu transferów Terry Banku:
         * 
         * .../amount.destNr.destName.srcNr.srcName.destination.source.title.isTransSuccessful(y/n)/...
         * 
         */

        public override List<BankTransfer> GetBankTransfers()
        {
            var fileContent = BankFileOperation.GetFileContent("123");
            var allTransArr = fileContent.Split('/');
            var bankTransList = new List<BankTransfer>();

            foreach (var entry in allTransArr)
            {
                bankTransList.Add(GetTransferEntry(entry));
            }

            return bankTransList;
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            var transArr = entry.Split('.');

            var transfer = new TerryBankTransfer(transArr[0], transArr[1], transArr[2], transArr[3],
                transArr[4], transArr[5], transArr[6], transArr[7], transArr[8]);
            
            return transfer;
        }
    }
}