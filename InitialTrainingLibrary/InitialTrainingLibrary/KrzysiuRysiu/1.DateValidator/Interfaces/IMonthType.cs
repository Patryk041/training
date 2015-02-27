using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.KrzysiuRysiu._1.DateValidator.Interfaces
{
	interface IMonthType
	{
		int minMonth;
		int maxMonth;

		bool ValidateMonth();
	}
}
