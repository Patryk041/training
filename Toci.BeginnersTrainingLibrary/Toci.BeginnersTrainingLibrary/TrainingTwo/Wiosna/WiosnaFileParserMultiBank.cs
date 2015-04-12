using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingTwo.common;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Streams;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.Wiosna
{
    public class WiosnaFileParserMultiBank : TransferFileParser
    {
        protected override TransferEntity GetRow(string row)
        {
            TransferEntity transferEntity = new TransferEntity();

            var bankData = StringHelper.GetSeparatedItems("\t", row);

            transferEntity.Account = bankData[0];
            transferEntity.Date = bankData[1];
            transferEntity.Amount = bankData[2];
            transferEntity.Name = bankData[3];
            transferEntity.Surname = bankData[4];
            transferEntity.Sender = null;

            return transferEntity;
        }
    }
}
