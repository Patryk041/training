using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Streams;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.Santi
{
	public class SantiTransfers : TranfersAggregator
	{
		public List<string> ReadTransferFiles()
		{
			List<string> TransferFiles;
			
			TransferFiles = Directory.GetFiles(@"..\..\..\Toci.BeginnersTrainingLibrary\TrainingTwo\data").ToList();

			return TransferFiles;
		}

		public override List<TransferEntity> GetAllTransfers(List<string> filePathsList)
		{
			List<TransferEntity> AllTransfers = new List<TransferEntity>();

			filePathsList.ForEach(item => AllTransfers.AddRange(
				SantiTransferFileParserFactory.CreateTransferFileParserObject(item).OpenFile(item)));

			return AllTransfers;
		}
	}
}
