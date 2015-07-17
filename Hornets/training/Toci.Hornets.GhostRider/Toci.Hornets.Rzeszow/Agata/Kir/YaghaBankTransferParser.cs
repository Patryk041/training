using System;
using System.Collections.Generic;
using System.Linq;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Rzeszow.Agata.Kir
{
    public class YaghaBankTransferParser : Toci.Hornets.GhostRider.Kir.BankTransfersParser
    {
        public override List<BankTransfer> GetBankTransfers()
        {
            BankFileOperation = new YaghaFileOperationsTxt();
            var fileContent =
                BankFileOperation.GetFileContent(
                    @"C:\aga\03_TOCI\01_TOCI_HORNETS\Repo\training\Hornets\training\Toci.Hornets.GhostRider\Toci.Hornets.Rzeszow\Agata\Kir\BankTransferFiles\YaghaTransfers.txt");
            var fileContentArray = fileContent.Split(' ');
            var transferList = new List<BankTransfer>();
            foreach (var transfer in fileContentArray)
            {
                transferList.Add(GetTransferEntry(transfer));
            }
            return transferList;
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            var transferDataArray = entry.Split(';');
            var bankTransfer = new YaghaBankTransfer();
            bankTransfer.TransferNumber = transferDataArray[0];
            bankTransfer.SourceAccountNumber = transferDataArray[1];
            bankTransfer.DestinationAccountNumber = transferDataArray[2];
            bankTransfer.DestinationAccountOwner = transferDataArray[3];
            bankTransfer.Amount = transferDataArray[4];
            bankTransfer.TransferTitle = transferDataArray[5];
            bankTransfer.DestinationBank = GetBankName(bankTransfer.DestinationAccountNumber);
            bankTransfer.SourceBank = GetBankName(bankTransfer.SourceAccountNumber);
            return bankTransfer;
        }

        protected string GetBankName(string accountNumber)
        {
            if (accountNumber.Count() != 26)
                throw new Exception("Zły numer konta");

            var bankIndetifire = Int32.Parse(accountNumber.Substring(2, 5));
            var bankList = GetAllBanks();
            return bankList[bankIndetifire];
        }

        public Dictionary<int, string> GetAllBanks()
        {
            Dictionary<int, string> bankDict = new Dictionary<int, string>();
            bankDict.Add(2490, "Alior");
            bankDict.Add(1010, "NBP");
            bankDict.Add(1030, "CityBank");
            bankDict.Add(1050, "ING");
            bankDict.Add(1090, "WBK");
            bankDict.Add(1130, "BGK");
            bankDict.Add(1140, "MBank");
            bankDict.Add(1060, "BPH");
            return bankDict;
        }

    }
}