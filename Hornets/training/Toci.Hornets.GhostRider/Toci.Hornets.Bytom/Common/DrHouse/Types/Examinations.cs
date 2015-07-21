using System.Collections.Generic;

namespace Toci.Hornets.Bytom.Common.DrHouse.Types
{
	public abstract class Examination
	{
		public string Name { get; set; }
		public List<ExaminationParameter> Parameters { get; set; }
	}
}
