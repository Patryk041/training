using System.Collections.Generic;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Rzeszow.Terry.TrainingThree.Bank
{
    public class TerryBankTransfersParser : BankTransfersParser
    {

        /* Format zapisu transferów Terry Banku:
         * 
         * .../destination.source.destNr.destName.srcNr.srcName.title.isTransSuccessful(y/n)/...
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

            var transfer = new BankTransfer
            {
                DestinationBank = transArr[0],
                SourceBank = transArr[1],
                IsTransferSuccessful = transArr[6] == "y"
            };
            
            return transfer;
        }
    }
}