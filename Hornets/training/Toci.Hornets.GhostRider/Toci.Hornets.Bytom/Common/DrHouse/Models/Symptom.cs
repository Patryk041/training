using System.Collections.Generic;

namespace Toci.Hornets.Bytom.Common.DrHouse.Models
{
	public class Symptom : ISicknessIndicator
	{
		public string Name { get; set; }
        public List<string> PartOfBody { get; set; }
		public string Description { get; set; }
	}
}
