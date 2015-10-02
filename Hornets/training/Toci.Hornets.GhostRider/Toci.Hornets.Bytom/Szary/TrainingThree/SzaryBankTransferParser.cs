using System.Collections.Generic;
using System;
using System.Linq;
using Toci.Hornets.GhostRider.Kir;


namespace Toci.Hornets.Bytom.Szary.TrainingThree
{
    public class SzaryBankTransferParser:BankTransfersParser
    {
        public override List<BankTransfer> GetBankTransfers()
        {
            BankFileOperation = new SzaryFileOperation();
            var lines = BankFileOperation.GetFileContent(UserrPath.Find() + "\\SuperBank.txt").Split(new[] { "\n" }, StringSplitOptions.None);
            return lines.Select(GetTransferEntry).ToList();
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            var words = entry.Split(new[] { " " }, StringSplitOptions.None);

            return new SzaryBankTransfer(words);
        }
    }
}