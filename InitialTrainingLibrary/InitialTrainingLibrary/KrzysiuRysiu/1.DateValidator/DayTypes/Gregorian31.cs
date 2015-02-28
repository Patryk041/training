using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.KrzysiuRysiu._1.DateValidator.Interfaces;

namespace InitialTrainingLibrary.KrzysiuRysiu._1.DateValidator.DayTypes
{
	public class Gregorian31 : IDayType
	{
		private int minDay = 1;
		private int maxDay = 31;
		private int[] validMonths = new int[7] 
		{	1,3,5,7,8,10,12	};

	public bool ValidateDay(int year, int month, int day)
	{
		return (minDay <= day && day <= maxDay) && (validMonths.Any(number => number == month));
	}
	}
}
											   