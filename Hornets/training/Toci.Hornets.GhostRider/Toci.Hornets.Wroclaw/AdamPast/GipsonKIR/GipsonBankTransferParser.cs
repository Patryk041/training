using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Wroclaw.AdamPast.GipsonKIR
{
    public class GipsonBankTransferParser : BankTransfersParser
    {
        new FileOperation BankFileOperation = new GipsonFileOperation();

        //dodac sciezke
        private const string Path = @"C:\TOCI repository\Hornets\training\Toci.Hornets.GhostRider\Toci.Hornets.Wroclaw\AdamPast\GipsonKIR\Transactions\Transactions1.txt";
        private const string Path2 = @"..\..\..\Toci.Hornets.Wroclaw\AdamPast\GipsonKIR\Transactions\Transactions1.txt";


        public override List<BankTransfer> GetBankTransfers()
        {
            List<BankTransfer> transfersList = new List<BankTransfer>();
            var transfersFileContents = BankFileOperation.GetFileContent(Path2);
            var result = Regex.Split(transfersFileContents, "\r\n|\r|\n");
            foreach (var line in result)
            {
                transfersList.Add(GetTransferEntry(line));
            }
            return transfersList;
            
        }





        public Dictionary<string, Func<GipsonBankTransfer,string,string>> ConversionDictionary = new Dictionary
            <string, Func<GipsonBankTransfer, string, string>>()
        {
            {"SourceBank", delegate(GipsonBankTransfer transfer,string entry)
            {
                transfer.SourceBank = GipsonKirUtils.CutOneField(entry);
                return GipsonKirUtils.CutTail(entry);
            }},
            {"SourceBankAccountName", delegate(GipsonBankTransfer transfer, string entry) 
            {
                transfer.SendingAccount = new GipsonBankAccount();
                transfer.SendingAccount.OwnerName = GipsonKirUtils.CutOneField(entry);
                return GipsonKirUtils.CutTail(entry);
            }},
            {"SourceBankAccountNumber", delegate(GipsonBankTransfer transfer, string entry) 
            {
                transfer.SendingAccount.AccountNumber = GipsonKirUtils.CutOneField(entry);
                return GipsonKirUtils.CutTail(entry);
            }},
            {"DestinationBank", delegate(GipsonBankTransfer transfer, string entry) 
            {
                transfer.DestinationBank = GipsonKirUtils.CutOneField(entry);
                return GipsonKirUtils.CutTail(entry);
            }},
            {"DestinationAccountName", delegate(GipsonBankTransfer transfer, string entry) 
            {
                transfer.ReceivingAccount = new GipsonBankAccount();
                transfer.ReceivingAccount.OwnerName = GipsonKirUtils.CutOneField(entry);
                return GipsonKirUtils.CutTail(entry);
            }},
            {"DestinationAccountNumber", delegate(GipsonBankTransfer transfer, string entry) 
            {
                transfer.ReceivingAccount.AccountNumber = GipsonKirUtils.CutOneField(entry);
                return GipsonKirUtils.CutTail(entry);
            }},
            {"Currency", delegate(GipsonBankTransfer transfer, string entry) 
            {
                transfer.Waluta = GipsonKirUtils.CutOneField(entry);
                return GipsonKirUtils.CutTail(entry);
            }},
            {"TransferValue", delegate(GipsonBankTransfer transfer, string entry) 
            {
                transfer.TransferAmmount = Convert.ToDouble(GipsonKirUtils.CutOneField(entry));
                return GipsonKirUtils.CutTail(entry);
            }},
            {"TransferDate", delegate(GipsonBankTransfer transfer, string entry) 
            {
                transfer.TransferDate = Convert.ToDateTime(GipsonKirUtils.CutOneField(entry));
                return GipsonKirUtils.CutTail(entry);
            }},
            {"TransferTitle", delegate(GipsonBankTransfer transfer, string entry) 
            {
                transfer.TransferTitle = GipsonKirUtils.CutOneField(entry);
                return GipsonKirUtils.CutTail(entry);
            }}
        };

        protected override BankTransfer GetTransferEntry(string entry)
        {
            GipsonBankTransfer transfer = new GipsonBankTransfer();
            string entryCopy = entry;
            foreach (var item in ConversionDictionary)
            {
                entryCopy=item.Value(transfer, entryCopy);
            }

            
            return transfer;
        }

    }
}