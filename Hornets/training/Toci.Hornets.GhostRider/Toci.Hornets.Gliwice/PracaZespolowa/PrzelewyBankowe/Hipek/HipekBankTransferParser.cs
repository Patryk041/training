using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Hipek
{
    public class HipekBankTransferParser : BankTransfersParser
    {
        private string _path =
            @"../../../Toci.Hornets.Gliwice/PracaZespolowa/PrzelewyBankowe/Hipek/HipekTransfers.txt";
       
        public override List<BankTransfer> GetBankTransfers()
        {
            BankFileOperation = new GliwiceFileOperation();
            string content = BankFileOperation.GetFileContent(_path);
            var contentSplited = Regex.Split(content, "\r\n");

            return contentSplited.Select(transfer => GetTransferEntry(transfer)).ToList();
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            HipekBankTransfer transfer = new HipekBankTransfer();
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
    }
}
