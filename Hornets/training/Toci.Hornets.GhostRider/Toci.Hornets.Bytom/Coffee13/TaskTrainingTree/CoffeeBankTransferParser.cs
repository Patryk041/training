using System.Collections.Generic;
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
            List<BankTransfer> listOfTransfers = new List<BankTransfer>();

            List<string> separatedFromMainString = new List<string>();

            var file = new CoffeeFileOperation();

            string transfers = file.GetFileContent(@"..\..\Coffee13\TaskTrainingTree\Transfers.xml");   //path?\

            separatedFromMainString = SeparateTransfers(transfers);

            foreach (var entry in separatedFromMainString)
            {
                 listOfTransfers.Add(GetTransferEntry(entry));
            }
            return listOfTransfers; 
        }

        protected override BankTransfer GetTransferEntry(string entry)  //tworzy ze stringa zawierającego pojedynczy transfer obiekt typu BankTransfer
        {
            return null; //tymczasowo
        }

        protected List<string> SeparateTransfers(string transfers)    //dzieli string zawierajacy caly plik na transfery
        {
            List<string> sepTrans = new List<string>();



            return sepTrans;
        }
    }
}