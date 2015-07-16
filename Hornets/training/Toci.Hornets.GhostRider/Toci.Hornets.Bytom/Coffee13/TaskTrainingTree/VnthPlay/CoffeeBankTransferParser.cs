using System.Collections.Generic;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Bytom.Coffee13.TaskTrainingTree.VnthPlay
{
    public class Coffee2BankTransferParser : BankTransfersParser
    {

        // wczytac plik do stringu
        // rozbic string na linie
        // linie przetworzyc GetTransferEntry na typ BankTransfer
        public override List<BankTransfer> GetBankTransfers()
        {
			var transfer = new Coffee2BankTransfer();

            var file = new CoffeeFileOperation();
            string transfers = file.GetFileContent(@"..\..\Coffee13\TaskTrainingTree\newTransfers.xml"); //path?\

            return null;

			//foreach iterujący po tablicy CoffeeBankTransferów

	        GetTransferEntry(Coffee2XmlSerialization.SerializeObjectToStringEntry(transfer));
        }

        protected override BankTransfer GetTransferEntry(string entry) //przyjmuje stringa transter (1 rekord), zwraca typ wypełniony danymi ze stringa
        {
			var transfer = new Coffee2BankTransfer();

	        return transfer as BankTransfer;




	        //todo: zwrócić CoffeeBankTransfer i scastować do BankTransfer (
	        //return transfers as BankTransfer;
        }

    }
}