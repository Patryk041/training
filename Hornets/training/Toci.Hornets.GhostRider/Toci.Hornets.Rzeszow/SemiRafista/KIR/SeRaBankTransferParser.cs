using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Rzeszow.SemiRafista.KIR
{
    public class SeRaBankTransferParser : BankTransfersParser
    {
        private readonly SeRaFileOperation _operations = new SeRaFileOperation();

        public override List<BankTransfer> GetBankTransfers()
        {
            return GetLinesOfTransfers().Select(GetTransferEntry).ToList();
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            entry = entry.Replace("\r", String.Empty);
            var singleTransferInfo = entry.Split('|');
            SeRaBankTransfer bank = new SeRaBankTransfer();
            if (singleTransferInfo[0].Length != 26 || singleTransferInfo[2].Length != 26)
            {
                throw new Exception("zly numer konta");
            }
            bank.SourceBankNumber = singleTransferInfo[0];
            bank.DestinationBankNumber = singleTransferInfo[2];
            bank.SourceClientName = singleTransferInfo[1];
            bank.DestinationClientName = singleTransferInfo[3];
            bank.TransferTitle = singleTransferInfo[4];
            bank.TransferAmount = singleTransferInfo[5];
            bank.TransferDate = singleTransferInfo[6];
            bank.SourceBank = GetBankName(bank.SourceBankNumber);
            bank.DestinationBank = GetBankName(bank.DestinationBankNumber);

            //jezeli przelew dotyczy mojego banku
            if (bank.SourceBank == "SeRaBank" || bank.DestinationBank == "SeRaBank")
            {
                return bank;
            }
            return null;
        }

        public string[] GetLinesOfTransfers()
        {
            string text = _operations.GetFileContent(@"F:\KURS C#\REPO\Hornets\training\Toci.Hornets.GhostRider\Toci.Hornets.Rzeszow\SemiRafista\KIR\demo\SeRaDemo.txt");
            return text.Split('\n');
        }

        protected static Dictionary<string, string> AllBanks = new Dictionary<string, string>()
        {
            {"1000", "SeRaBank"},
            {"2000", "TerryBank"},
            {"3000", "ING"},
            {"4000", "AliorBank"},
            {"5000","mBank"}
        };
        private string GetBankName(string accNumber)
        {
            return AllBanks[accNumber.Substring(0, 4)];
        }
    }
}