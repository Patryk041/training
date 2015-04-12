using Toci.BeginnersTrainingLibrary.TrainingTwo.common;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Streams;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.Matwie
{
    class IngTransferFileParser : TransferFileParser
    {
        protected override TransferEntity GetRow(string row)
        {
            //nazwisko; imie; konto; kwota; data; nadawaca;
            var data = StringHelper.GetSeparatedItems("; ", row);
            //data.Count ==  6 ?
            TransferEntity entity = new TransferEntity();

            entity.Surname = data[0];
            entity.Name = data[1];
            entity.Account = data[2];
            entity.Amount = data[3];
            entity.Date = data[4];
            entity.Sender = data[5];

            return entity;
        }
    }
}
