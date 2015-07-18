using System;
using System.Collections.Generic;
using System.Linq;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.PiotrekJ
{
    public class PiotrekJBankTransferParser : BankTransfersParser
    {
        private static FileOperation fileOperation = new GliwiceFileOperation();
        private List<BankTransfer> _bankTransfersList;
        private string _filePath = fileOperation.GetFileContent(@"..\\..\\..\\Toci.Hornets.Gliwice\\PracaZespolowa\\PrzelewyBankowe\\PiotrekJ\\PiotrekJBankTransfersList.txt");
        private string[] _entriesSeparator = { "\r\n", ";" };

        public override List<BankTransfer> GetBankTransfers()
        {
            _bankTransfersList = new List<BankTransfer>();
            List<string> transfersList = CutBankTransfers(_filePath);
            foreach (var transfer in transfersList)
            {
                _bankTransfersList.Add(GetTransferEntry(transfer));
            }
            return _bankTransfersList;
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            PiotrekJBankTransfer transfer = new PiotrekJBankTransfer();
            var entrySplited = entry.Split(';');
            transfer.SourceBank = entrySplited[0];
            transfer.SourceAccount = entrySplited[1];
            transfer.SourceUserName = entrySplited[2];
            transfer.DestinationBank = entrySplited[3];
            transfer.DestinationAccount = entrySplited[4];
            transfer.DestinationUserName = entrySplited[5];
            transfer.Cash = double.Parse(entrySplited[6]);
            transfer.Title = entrySplited[7];
            transfer.SendDate = entrySplited[8];
            return transfer;
        }

        private List<string> CutBankTransfers(string file)
        {
            List<string> transfers = file.Split(_entriesSeparator[0].ToCharArray()).ToList();
            List<string> newTransfers = new List<string>();
            foreach (var item in transfers)
            {
                if (item != String.Empty)
                {
                    newTransfers.Add(item);
                }
            }
            return newTransfers;
        }
    }
}