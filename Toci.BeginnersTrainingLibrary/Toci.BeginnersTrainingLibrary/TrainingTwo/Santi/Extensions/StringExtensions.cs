using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.Santi.Extensions
{
	public static class StringExtensions
	{
		public static string GetBankFileName(this string filePath)
		{
			return filePath.Substring(filePath.LastIndexOf("data") + 5);
		}
	}
}
