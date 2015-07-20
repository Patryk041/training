using System.Collections.Generic;

namespace Toci.Hornets.Bytom.Common.DrHouse
{
	public class Illness
	{
		public string Name { get; set; }
		public List<Symptom> Symptoms { get; set; }
		public string Description { get; set; }
		public string Counteractions { get; set; }
	}
}
