using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Hornets.Bytom.Common.DrHouse
{
	public abstract class Examination
	{
		public string Name { get; set; }
		public List<ExaminationParameter> Parameters { get; set; }
	}
}
