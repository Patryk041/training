using System;
using System.Collections.Generic;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.Files;

namespace Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.BankTransfersParsers
{
    public class NordeaBankTransfersParser : BankTransfersParser
    {
        private readonly List<BankTransfer> _bankTransfers; 


        public NordeaBankTransfersParser(FileOperation fileOperation)
        {
            BankFileOperation = fileOperation;
            _bankTransfers = new List<BankTransfer>();
        }

        public override List<BankTransfer> GetBankTransfers()
        {
            foreach (var path in AlmostLikeADatebase.GetBankTransferToDo("Nordea"))
                PopulateBankTransfers(path);
            return _bankTransfers;
        }

        private void PopulateBankTransfers(string path)
        {
            string textFromFile = BankFileOperation.GetFileContent(path);
            foreach (var line in textFromFile.Split('\n'))
            {
                _bankTransfers.Add(GetTransferEntry(line));
            }
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            var tab = entry.Split('\t');
            return new LegnicaBankTransfer
            {
                DestinationBank = tab[0],
                SourceBank = tab[1],
                DestinationBankNumber = tab[2],
                SourceBankNumber = tab[3],
                Amount = int.Parse(tab[4]),
                Date = DateTime.Parse(tab[5])              
            };           
        }
    }
}