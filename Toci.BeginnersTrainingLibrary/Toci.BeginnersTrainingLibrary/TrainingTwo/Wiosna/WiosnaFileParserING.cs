using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingTwo.common;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Streams;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.Wiosna
{
    public class WiosnaFileParserING : TransferFileParser
    {
        protected override TransferEntity GetRow(string row)
        {
            TransferEntity transferEntity = new TransferEntity();

            var bankData = StringHelper.GetSeparatedItems("; ", row);

            transferEntity.Surname = bankData[0];
            transferEntity.Name = bankData[1];
            transferEntity.Account = bankData[2];
            transferEntity.Amount = bankData[3];
            transferEntity.Date = bankData[4];
            transferEntity.Sender = bankData[5];

            return transferEntity;
        }
    }
}
