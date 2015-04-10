using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Streams;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.Santi
{
	public class SantiTransferFileParserMultibank : TransferFileParser
	{
		protected override TransferEntity GetRow(string row)
		{
			TransferEntity TransferEntity = new TransferEntity();

			List<string> SeparatedItems = SantiStringHelper.GetSeparatedItems("\t", row);

			TransferEntity.Account = SeparatedItems[0];
			TransferEntity.Date = SeparatedItems[1];
			TransferEntity.Amount = SeparatedItems[2];
			TransferEntity.Name = SeparatedItems[3];
			TransferEntity.Surname = SeparatedItems[4];
			TransferEntity.Sender = null;

			return TransferEntity;
		}
	}
}
