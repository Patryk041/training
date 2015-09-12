using System.Collections.Generic;
using System.Linq;
using Anathema.Patryk.TrainingTwo.Models;

namespace Anathema.Patryk.TrainingTwo.Banks.Handlers
{
    public class TxtBankTransferParser : TxtParser<BankTransfer>
    {
       /* public TxtBankTransferParser() : base('\t')
        {
        }*/

        protected override BankTransfer GetResult(string entry)
        {
            var list = entry.Split('\t');

            return new BankTransfer()
            {
                SourceBankName = list[0],
                DestinationBankName = list[1],
                Amount = double.Parse(list[2])
            };
        }
    }
}