using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Streams;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.Santi
{
	public class SantiTransferFileParserING : TransferFileParser
	{
		protected override TransferEntity GetRow(string row)
		{
			TransferEntity TransferEntity = new TransferEntity();

			List<string> SeparatedItems = SantiStringHelper.GetSeparatedItems("; ", row);

			TransferEntity.Surname = SeparatedItems[0];
			TransferEntity.Name = SeparatedItems[1];
			TransferEntity.Account = SeparatedItems[2];
			TransferEntity.Amount = SeparatedItems[3];
			TransferEntity.Date = SeparatedItems[4];
			TransferEntity.Sender = SeparatedItems[5];

			return TransferEntity;
		}
	}
}
