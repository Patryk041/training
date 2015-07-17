using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.GhostRider.TrainingThree.Chor;
using Toci.Hornets.Rzeszow.Foonesh.TrainingThree;

namespace Toci.Hornets.Rzeszow.KSebal.traningThreeHomework
{
    public class KsebalBankTransferParser : BankTransfersParser
    {
        public override List<BankTransfer> GetBankTransfers()
        {   BankFileOperation = new FileOperationFoonesh();
            var lines = BankFileOperation.GetFileContent(UserPath.find()+"\\SuperBank.txt").Split(new[] {"\n"}, StringSplitOptions.None);
            return lines.Select(GetTransferEntry).ToList();
           
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
           
            var words = entry.Split(new []{" "}, StringSplitOptions.None);

            return new KsebalBankTransfer(words);
        }

    }
}
