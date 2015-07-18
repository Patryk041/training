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
                    @"D:\Szkolenie C#\SoutceTree\Hornets\training\Toci.Hornets.GhostRider\Toci.Hornets.Opole\Lausion\LausionKIR\TextFile1.txt");
            
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

            return new LausionBankTransfer()
            {
                SourceBank = GetBankName(contentInLine[0]),
                DestinationBank = contentInLine[1],
                Amount = Double.Parse(contentInLine[2]),
                Date = contentInLine[5],
                Recipent = contentInLine[4],
                Sender = contentInLine[3],
                Title = contentInLine[6]
            };

        }

        private string GetBankName(string account)
        {
            int accNumber = Int32.Parse(account);
            if (accNumber == 1050)
                return "ING";
            else if (accNumber == 1060)
                return "BPH";
            else if (accNumber == 1280)
                return "HSBC";
            else
            {
                return null;
            }
        }
    }
}