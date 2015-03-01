using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.KrzysiuRysiu._1.DateValidator.Interfaces;

namespace InitialTrainingLibrary.KrzysiuRysiu._1.DateValidator.MonthTypes
{
	public class GregorianMonths : IMonthType
	{
	    private const int minMonth = 1;
	    private int maxMonth = 12;

		public bool ValidateMonth(int month)
		{
			return month >= minMonth && month <= maxMonth;
		}
	}
}
