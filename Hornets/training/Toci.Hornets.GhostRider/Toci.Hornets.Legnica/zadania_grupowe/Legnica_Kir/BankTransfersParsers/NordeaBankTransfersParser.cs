using System.Collections.Generic;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.BankTransfersParsers
{
    public class NordeaBankTransfersParser : BankTransfersParser
    {
        private string _path;
        public NordeaBankTransfersParser(FileOperation fileOperation,string path)
        {
            _path = path;
            BankFileOperation = fileOperation;
        }

        public override List<BankTransfer> GetBankTransfers()
        {
            string str = BankFileOperation.GetFileContent(_path);
            var tab = str.Split(new[] {'\n'});
            var tab2 = tab[0].Split(new[] {'\t'});
            return null;
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            throw new System.NotImplementedException();
        }
    }
}