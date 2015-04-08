using Toci.BeginnersTrainingLibrary.TrainingTwo.common;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Streams;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.Matwie
{
    class MultibankTransferFileParser : TransferFileParser
    {
        protected override TransferEntity GetRow(string row)
        {
            //konto	data	kwota	imie	nazwisko
            var data = StringHelper.GetSeparatedItems("\t", row);
            TransferEntity entity = new TransferEntity();

            entity.Account = data[0];
            entity.Date = data[1];
            entity.Amount = data[2];
            entity.Name = data[3];
            entity.Surname = data[4];

            return entity;
        }
    }
}
