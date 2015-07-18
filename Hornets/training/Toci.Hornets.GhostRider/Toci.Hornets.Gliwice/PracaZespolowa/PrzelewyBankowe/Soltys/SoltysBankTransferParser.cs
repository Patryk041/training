using System;
using System.Collections.Generic;
using System.Linq;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Soltys
{
    public class SoltysBankTransferParser : BankTransfersParser
    {
        private const string FilePath =
            "../../../Toci.Hornets.Gliwice/PracaZespolowa/PrzelewyBankowe/Soltys/SoltysBankTransferData.txt";

        private readonly char[] _entriesSeparators = {'\n', '\r'};
        private const char ValuesSeparator = ';';

        public override List<BankTransfer> GetBankTransfers()
        {
            var fileOperation = new GliwiceFileOperation();
            var fileContent = fileOperation.GetFileContent(FilePath);

            var fileEntries = fileContent.Split(_entriesSeparators, StringSplitOptions.RemoveEmptyEntries);

//            foreach (var fileEntry in fileEntries)
//            {
//                bankTransfersList.Add(GetTransferEntry(fileEntry));
//            }
//
//            return bankTransfersList;

            // Skrócona wersja kodu napisanego powyżej w komentarzu
            return fileEntries.Select(GetTransferEntry).ToList();
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            // Remove curly brackets
            entry = entry.Replace("{", "").Replace("}", "");

            // Split data parts
            var dataParts = entry.Split(ValuesSeparator);

            IDictionary<string, string> myDictionary = new Dictionary<string, string>();

            foreach (var dataPart in dataParts)
            {
                myDictionary.Add(GetTransferKeyValuePair(dataPart));
            }

            return PopulateBankTransfer(myDictionary);
        }

        private KeyValuePair<string, string> GetTransferKeyValuePair(string textLine)
        {
            var splitedText = textLine.Split(new[] {':'}, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < splitedText.Length; i++)
            {
                splitedText[i] = splitedText[i].Replace("\"", "");
                splitedText[i] = splitedText[i].Replace(" ", String.Empty);
            }

            return new KeyValuePair<string, string>(splitedText[0], splitedText[1]);
        }

        private BankTransfer PopulateBankTransfer(IDictionary<string, string> valuesDictionary)
        {
            var bankTransfer = new SoltysBankTransfer
            {
                SourceBank = valuesDictionary["SourceBank"],
                DestinationBank = valuesDictionary["DestinationBank"],
                Amount = Convert.ToDecimal(valuesDictionary["Amount"]),
                SenderName = valuesDictionary["SenderName"],
                ReceiverName = valuesDictionary["ReceiverName"],
                TransferDate = Convert.ToDateTime(valuesDictionary["TransferDate"]),
                Title = valuesDictionary["Title"]
            };

            var transferHandler =
                SoltysTransferHandlerFactory.GetValidTransferHandler(valuesDictionary["DestinationBank"]);

            if (transferHandler != null)
            {
                transferHandler.SendTransfer(bankTransfer);
            }

            return bankTransfer;
        }
    }
}
