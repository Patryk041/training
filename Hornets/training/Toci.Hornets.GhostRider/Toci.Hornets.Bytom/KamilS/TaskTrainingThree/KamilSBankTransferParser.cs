using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Bytom.KamilS.TaskTrainingThree
{
    class KamilSBankTransferParser : BankTransfersParser
    {
        public override List<BankTransfer> GetBankTransfers()
        {
            // wczytac plik do stringu
            // rozbic string na linie
            // linie przetworzyc GetTransferEntry na typ BankTransfer
            BankFileOperation = new KamilSFileOperation();
            List<BankTransfer> bankTransferList = new List<BankTransfer>();
            string bankTransfers = BankFileOperation.GetFileContent(@"..\..\KamilS\TaskTrainingThree\TaskThree.txt");
            foreach (String s in bankTransfers.Split('\n'))
            {
                bankTransferList.Add(GetTransferEntry(s));
            }
            return bankTransferList;
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            BankTransfer bankTransfer = new BankTransfer
            {
                SourceBank = entry.Split(';')[0],
                DestinationBank = entry.Split(';')[1]
            };
            return bankTransfer;
        }
    }
}
