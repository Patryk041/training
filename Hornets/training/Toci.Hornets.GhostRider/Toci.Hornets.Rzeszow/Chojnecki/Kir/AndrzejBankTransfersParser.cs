using System;
using System.Collections.Generic;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Rzeszow.Chojnecki.Kir
{
    public class AndrzejBankTransfersParser : BankTransfersParser
    {
        public override List<BankTransfer> GetBankTransfers()
        {
           var transfersList = new List<BankTransfer>();
           const string path = "C:\\Hornets\\Hornets\\training\\Toci.Hornets.GhostRider\\Toci.Hornets.Rzeszow\\Chojnecki\\Kir\\Przelewy.txt";
           var bankTransfers = new AndrzejFileOperation().GetFileContent(path);
           foreach (String s in bankTransfers.Split())
           {
               transfersList.Add(GetTransferEntry(s));
           }
           return transfersList;
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {

            BankTransfer bankTransfer = new BankTransfer();
            bankTransfer.SourceBank = entry.Split(';')[0];
            bankTransfer.DestinationBank = entry.Split(';')[1];
            return bankTransfer;
        }


    }
}