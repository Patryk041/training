namespace Toci.BeginnersTrainingLibrary.TrainingTwo.ksebal
{
    public class TransferFileParserMultibank : TransferFileParser
    {
        private const string SeparatorMultibank = " ";
        public override TransferEntity GetRow(string row)
        {

            var elements = StringHelper.GetSeparatedItems(SeparatorMultibank, row);

            var entity = new TransferEntity();

            entity.Name = elements[0]; //konto
            entity.Surname = elements[1]; //konto
            entity.Account = elements[2];
            entity.Amount = elements[3];
            entity.Date = elements[4];
            entity.Sender = elements[5];
            return entity;
        }
    }
}