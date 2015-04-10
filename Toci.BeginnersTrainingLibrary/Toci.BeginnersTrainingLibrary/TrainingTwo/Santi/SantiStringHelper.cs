using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.Santi
{
	public static class SantiStringHelper
	{
		public static List<string> GetSeparatedItems(string separator, string line)
		{
			List<string> SeparatedItems = new List<string>();
			
			SeparatedItems = line.Split(new[] { separator }, StringSplitOptions.None).ToList();

			for(int i=0; i<SeparatedItems.Count; i++)
			{
				if(SeparatedItems[i].Contains(';'))
					SeparatedItems[i] = SeparatedItems[i].Replace(";", string.Empty);
			}

			return SeparatedItems;
		}
	}
}
