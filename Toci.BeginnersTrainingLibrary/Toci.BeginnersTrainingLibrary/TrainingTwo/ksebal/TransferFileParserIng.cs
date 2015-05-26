namespace Toci.BeginnersTrainingLibrary.TrainingTwo.ksebal
{
    public class TransferFileParserIng : TransferFileParser

    {
        private const string SeparatorIng = "\t";

        public override TransferEntity GetRow(string row)
        {
            var elements2 = StringHelper.GetSeparatedItems(SeparatorIng, row);

            var entity = new TransferEntity();

            //konto
            entity.Name = elements2[0];
            entity.Surname = elements2[1]; //konto
            entity.Account = elements2[2];
            entity.Amount = elements2[3];
            entity.Date = elements2[4];
            entity.Sender = elements2[5];

            
            

            return entity;
        }
    }
}