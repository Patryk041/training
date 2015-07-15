using System;
using System.Collections.Generic;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Wroclaw.ProjectElixir
{
    public class BankTrasfersParsersWroclaw : BankTransfersParser
    {
        private FileOperationsWroclaw myFileOperation;

        public override List<BankTransfer> GetBankTransfers()
        {
            var fileContent = myFileOperation.GetFileContent("c:/myTxt.txt");
            var fileLinesList = SeparateLines(fileContent);
            var myBankTransferList = new List<BankTransfer>();

            foreach (var line in fileLinesList)
            {

                var newBank = GetTransferEntry(line);

                myBankTransferList.Add(newBank);
            }


            return myBankTransferList;
        }

        private List<string> SeparateLines(string fileContent)
        {
            var fileLinesList = new List<string>();

            // logic

            return fileLinesList;
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            BankTransfer newBankTrasfer = new BankTransfer();

            // logic..

            return newBankTrasfer;
        }
    }
}