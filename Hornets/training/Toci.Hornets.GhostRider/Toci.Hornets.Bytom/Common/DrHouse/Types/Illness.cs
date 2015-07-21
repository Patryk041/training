using System.Collections.Generic;

namespace Toci.Hornets.Bytom.Common.DrHouse.Types
{
	public class Illness                                        //przechowuje chorobe wywnioskowaną na podstawie symptomów pacjenta porównanych z DB
	{
		public string Name { get; set; }
		public List<Symptom> Symptoms { get; set; }
		public string Description { get; set; }
		public string Counteractions { get; set; }
		public Dictionary<Patient, int> RiskOfIllnesBasedOnPatientType { get; set; }
	}
}
