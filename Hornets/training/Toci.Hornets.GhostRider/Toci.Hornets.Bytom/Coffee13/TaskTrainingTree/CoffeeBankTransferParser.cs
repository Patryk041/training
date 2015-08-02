using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Bytom.Coffee13.TaskTrainingTree
{
    public class CoffeeBankTransferParser : BankTransfersParser
    {

        // wczytac plik do stringu
        // rozbic string na linie
        // linie przetworzyc GetTransferEntry na typ BankTransfer
        public override List<BankTransfer> GetBankTransfers()
        {
            List<string> stringsSerparatedFromMainContent = new List<string>();
            List<BankTransfer> listOfBankTransfers = new List<BankTransfer>();

            var file = new CoffeeFileOperation();
            string mainContent = file.GetFileContent(@"..\..\Coffee13\TaskTrainingTree\newTransfers.xml"); //path?\

            stringsSerparatedFromMainContent = CoffeeDeserialization.SplitMainStringtoTransferStrings(mainContent);

            foreach (var entry in stringsSerparatedFromMainContent)
            {
                listOfBankTransfers.Add(GetTransferEntry(entry));
            }


            return listOfBankTransfers;
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            return CoffeeDeserialization.DeserializeString(entry);
        }

    }
}