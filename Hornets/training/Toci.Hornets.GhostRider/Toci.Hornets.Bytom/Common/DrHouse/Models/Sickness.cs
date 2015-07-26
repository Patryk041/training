using System.Collections.Generic;

namespace Toci.Hornets.Bytom.Common.DrHouse.Models
{
	public class Sickness                                      //przechowuje chorobe wywnioskowaną na podstawie symptomów pacjenta porównanych z DB
	{
		public string Name { get; set; }
		public List<ISicknessIndicator> SicknessIndicators { get; set; }
		public string Description { get; set; }
		public string Counteractions { get; set; }
        public Dictionary<PatientType, int> RiskOfSicnessBasedOnPatientType { get; set; }
	}
}
