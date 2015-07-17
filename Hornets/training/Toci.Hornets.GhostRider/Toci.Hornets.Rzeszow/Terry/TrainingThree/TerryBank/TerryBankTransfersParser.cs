using System;
using System.Collections.Generic;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Rzeszow.Terry.TrainingThree.TerryBank
{
    public class TerryBankTransfersParser : BankTransfersParser
    {

        /* Format zapisu transferów Terry Banku (docelowo, jeszcze to do końca tak nie wygląda):
         * 
         * .../amount.destination.destNr.destName.source.srcNr.srcName.title.isTransSuccessful(y/n)/...
         * 
         */

        public override List<BankTransfer> GetBankTransfers()
        {
            const string path = "..\\..\\..\\Toci.Hornets.Rzeszow\\Terry\\TrainingThree\\TerryBank\\transfers\\TerryBankAllTransfers.txt";
            var fileOp = new TerryFileOperation();
            var fileContent = fileOp.GetFileContent(@path);
            var allTransArr = fileContent.Split('/');
            var bankTransList = new List<BankTransfer>();

            foreach (var entry in allTransArr)
            {
                if (GetTransferEntry(entry).SourceBank != null)
                  bankTransList.Add(GetTransferEntry(entry.Replace("\r\n", String.Empty)));
            }

            return bankTransList;
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            var transArr = entry.Split('.');

            if (transArr.Length == 9)
            {
                return new TerryBankTransfer(transArr[0], transArr[1], transArr[2], transArr[3],
                    transArr[4], transArr[5], transArr[6], transArr[7], transArr[8]);
            }
            
            return new TerryBankTransfer();
        }
    }
}