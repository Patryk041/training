using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Streams;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Santi.Extensions;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.Santi
{
	public static class SantiTransferFileParserFactory
	{
		public static TransferFileParser CreateTransferFileParserObject(string filePath)
		{
			TransferFileParser TransferFileParser = null;

			switch(filePath.GetBankFileName())
			{
				case "ing.txt":
					TransferFileParser = new SantiTransferFileParserING();
					break;
				case "multibank.txt":
					TransferFileParser = new SantiTransferFileParserMultibank();
					break;
			}

			return TransferFileParser;
		}
	}
}
