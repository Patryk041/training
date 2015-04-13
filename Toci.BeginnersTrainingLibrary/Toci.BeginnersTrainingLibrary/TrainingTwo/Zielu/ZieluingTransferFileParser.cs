using Toci.BeginnersTrainingLibrary.TrainingTwo.common;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Streams;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.Zielu
{
    class ZieluingTransferFileParser:TransferFileParser
    {
        private const string Separator = "; ";
        protected override TransferEntity GetRow(string row)
        {
            var transfer = StringHelper.GetSeparatedItems(Separator, row);
            var entity = new TransferEntity
            {
                Name = transfer[1],
                Surname = transfer[0],
                Account = transfer[2],
                Amount = transfer[3],
                Date = transfer[4],
                Sender = transfer[5]
            };
            return entity;
        }
    }
}
