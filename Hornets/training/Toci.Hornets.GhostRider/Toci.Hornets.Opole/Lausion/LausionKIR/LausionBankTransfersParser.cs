using System;
using System.Collections.Generic;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Opole.OpoleKir;

namespace Toci.Hornets.Opole.Lausion.LausionKIR
{
    public class LausionBankTransfersParser:BankTransfersParser
    {
        public LausionBankTransfersParser()
        {
            BankFileOperation=new OpoleFileOperation();
        }

        public override List<BankTransfer> GetBankTransfers()
        {
            string content =
                BankFileOperation.GetFileContent(
                    @"D:\Szkolenie C#\SoutceTree\Hornets\training\Toci.Hornets.GhostRider\Toci.Hornets.Opole\Lausion\LausionKIR\Content.txt");
            
            string[] AllLines = content.Split('\n');
            
            List<BankTransfer> BankTransferList=new List<BankTransfer>();

            foreach (var allLine in AllLines)
            {
                BankTransferList.Add(GetTransferEntry(allLine));
            }

            return BankTransferList;
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            string[] contentInLine = entry.Split(';');
            return null;

        }
    }
}