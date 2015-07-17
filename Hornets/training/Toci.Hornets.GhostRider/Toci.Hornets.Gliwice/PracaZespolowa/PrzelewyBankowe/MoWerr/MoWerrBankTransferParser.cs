using System;
using System.Collections.Generic;
using System.Linq;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.MoWerr
{
    public class MoWerrBankTransferParser : BankTransfersParser
    {
        private const string FilePath = @"../../../Toci.Hornets.Gliwice/PracaZespolowa/PrzelewyBankowe/MoWerr/BankTransfers.txt";

        public override List<BankTransfer> GetBankTransfers()
        {
            var fileOperation = new GliwiceFileOperation();
            var fileContent = fileOperation.GetFileContent(FilePath);

            var separators = new char[] {'\n', '\r'};

            var transferEntries = fileContent.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            //reSharper faktycznie uczy programowania :D
            return transferEntries.Select(GetTransferEntry).ToList();
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            var entryArray = entry.Split(';');

            var bankTransfer = new MoWerrBankTransfer
            {
                SourceBank = entryArray[0],
                DestinationBank = entryArray[1],
                SenderName = entryArray[2],
                ReciverName = entryArray[3],
                Amount = float.Parse(entryArray[4]),
                TransferDate = DateTime.Parse(entryArray[5]),
                Title = entryArray[6]
            };

            var transferHandler = MoWerrTransferHandlerFactory.GetTransferHandler(bankTransfer.DestinationBank);

            if (transferHandler != null)
            {
                transferHandler.SendTransfer(bankTransfer);
            }
            else
            {
                bankTransfer.IsTransferSuccessful = false;
            }

            return bankTransfer;
        }
    }
}