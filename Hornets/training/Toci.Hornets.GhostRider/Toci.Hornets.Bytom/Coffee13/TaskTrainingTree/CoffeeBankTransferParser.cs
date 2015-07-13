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
            var file = new CoffeeFileOperation();
            string transfers = file.GetFileContent(@"..\..\Bytom\Coffee13\ContentFile.txt");
            BankTransfer transfer = GetTransferEntry(transfers);

            return null; //tymczasowo
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            return null; //tymczasowo
        }
    }
}