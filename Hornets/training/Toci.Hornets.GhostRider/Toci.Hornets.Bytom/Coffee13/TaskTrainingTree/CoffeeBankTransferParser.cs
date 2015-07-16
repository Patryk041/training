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

            var file = new CoffeeFileOperation();
            string transfers = file.GetFileContent(@"..\..\Coffee13\TaskTrainingTree\newTransfers.xml"); //path?\

            return null;


        }

        protected override BankTransfer GetTransferEntry(string entry)
        {

            CoffeeBankTransfer transfers = null;

            XmlSerializer serializer = new XmlSerializer(typeof (CoffeeBankTransfer));

            using (TextReader reader = new StringReader(entry))
            {
                transfers = (CoffeeBankTransfer) serializer.Deserialize(reader);
            }

            
            

            return null;
        }

    }
}