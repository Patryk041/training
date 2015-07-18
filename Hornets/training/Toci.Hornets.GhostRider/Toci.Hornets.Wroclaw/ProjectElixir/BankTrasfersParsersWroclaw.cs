using System;
using System.Collections.Generic;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Wroclaw.ProjectElixir
{
    public class BankTrasfersParsersWroclaw : BankTransfersParser
    {
        private FileOperationsWroclaw myFileOperation;
        private static  char _separator;
    


        private BankTrasfersParsersWroclaw() // prywatny konstruktor aby nie mozna bylo otrzymac instancji bez ustawienia separatora
        {
        }

       public static BankTrasfersParsersWroclaw getInstance(char Separator)
        {
            _separator = Separator;
            return new BankTrasfersParsersWroclaw();
        }


        public override List<BankTransfer> GetBankTransfers()
        {
            var fileContent = myFileOperation.GetFileContent(@"c:/1.txt");
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
            string[] stringSeparators = new string[] { "\r\n" };
            var lineList = fileContent.Split(stringSeparators,StringSplitOptions.None);

            foreach (var line in lineList)
            {
               fileLinesList.Add(line);
                
            }

            return fileLinesList;
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            var newBankTrasfer = FillWroclawBankEntity(entry);

            return newBankTrasfer;
        }

        private BankTransferWroclaw FillWroclawBankEntity(string entry)
        {
            BankTransferWroclaw newBankTrasfer = new BankTransferWroclaw();
            if (_separator == null)
                throw new Exception("There is no set separator!");
            var myEntries = entry.Split(_separator);

            newBankTrasfer.AccountNumber = Convert.ToInt32(myEntries[0]);
            newBankTrasfer.DestinationAddress = myEntries[1];
            newBankTrasfer.DestinationName = myEntries[2];
            newBankTrasfer.DestinyBank = myEntries[3];
            newBankTrasfer.IsTransferSuccessful = Convert.ToBoolean(myEntries[4]);
            newBankTrasfer.SourceBank = myEntries[5];
            newBankTrasfer.TransactionTime = Convert.ToDateTime(myEntries[6]);
            return newBankTrasfer;
        }
    }
}