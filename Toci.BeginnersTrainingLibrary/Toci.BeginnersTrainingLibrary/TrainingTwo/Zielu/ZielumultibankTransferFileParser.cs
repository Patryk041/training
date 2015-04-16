using Toci.BeginnersTrainingLibrary.TrainingTwo.common;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Streams;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.Zielu
{
    class ZielumultibankTransferFileParser: TransferFileParser
    {
        private const string Separator = "\t";
        protected override TransferEntity GetRow(string row)
        {
            var transfer = StringHelper.GetSeparatedItems(Separator, row);
            var entity = new TransferEntity
            {
                Name = transfer[3],
                Surname = transfer[4],
                Account = transfer[0],
                Amount = transfer[2],
                Date = transfer[1],
                Sender = null
            };
            return entity;
        }
    }
}
