using Anathema.Patryk.TrainingTwo.Banks.Models;
using Anathema.Patryk.TrainingTwo.Banks.Parsers.Abstract;

namespace Anathema.Patryk.TrainingTwo.Banks.Parsers
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