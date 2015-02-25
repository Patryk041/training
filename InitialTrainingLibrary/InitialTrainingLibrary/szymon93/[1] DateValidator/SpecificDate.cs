using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.szymon93._1__DateValidator
{
	class SpecificDate : Shared
	{
		int day, month, year;
		List<int[]> Months = new List<int[]>();

		public SpecificDate(int SpecificDay, int SpecificMonth, int SpecificYear)
		{
			day = SpecificDay;
			month = SpecificMonth;
			year = SpecificYear;

			Months = EnterDataAboutDaysInMonths(year);
		}

		public bool CheckDateSpecific()
		{
			

			return false;
		}
	}
}
