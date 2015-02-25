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
<<<<<<< HEAD
			MonthsChecker monthChecker = new MonthsChecker(month);
			return IsDayCorrect(Months[month-1]);
=======
			return IsDayCorrect(Months[month - 1]);
>>>>>>> 1a9c37746faf2d248cedfea24d1a54882a89767c
		}

		private bool IsDayCorrect(int[] DaysInMonth)
		{
			if(day <= DaysInMonth.Count())  
				return true;
			else 
				return false;
		}

		public void ClearData()
		{
			Months.Clear();
		}
	}
}
