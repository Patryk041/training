using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Sieradz.SieradzBankTransferTask.SieradzBankUtils;

namespace Toci.Hornets.Sieradz.SieradzBankTransferTask.BPH
{
    public class QuicksilverBankTransfersParser : BankTransfersParser
    {

        public override List<BankTransfer> GetBankTransfers()
        {
            List<BankTransfer> BankTransferItems = new List<BankTransfer>();
            BankFileOperation = new SieradzFileOperation();
            string fileContainer =
                File.ReadAllText(SieradzBankFilesPathHolder.TransferFilesPath + @"BphBankTransfers.bph");
            var fileLines = fileContainer.Split('\n');
            foreach (var x in fileLines)
            {
                if (x.Contains("Klucz:")) continue;
               
                BankTransferItems.Add(GetTransferEntry(x));
            }
            return BankTransferItems;
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            SieradzBankTransfer bt = new SieradzBankTransfer();
            //SieradzBankTransfersUtils bankDictionary;
            var ArgList = entry.Split('$');
            var bankDictionary = SieradzBankTransfersUtils.Instance;
            
            bt.SourceBank = bankDictionary.GetBankName(ArgList[0].Substring(2, 4));
            bt.DestinationBank = bankDictionary.GetBankName(ArgList[1].Substring(2, 4));

            bt.TransferInfo.SourceAccountNumber = ArgList[0];
            bt.TransferInfo.DestinationAccountNumber = ArgList[1];
            bt.TransferInfo.Amount = ArgList[2];
            bt.TransferInfo.SourcePersonName = ArgList[3];
            bt.TransferInfo.DestinationPersonName = ArgList[4];
            bt.TransferInfo.TransferTitle = ArgList[5];
            bt.TransferInfo.TransferDate = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");

            return bt;

        }
    }
}