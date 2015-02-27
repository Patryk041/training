using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.KrzysiuRysiu._1.DateValidator.Interfaces;

namespace InitialTrainingLibrary.KrzysiuRysiu._1.DateValidator.DayTypes
{
	public class GregorianException : IDayType
	{
		private int minDay = 1;
		private int maxDay = 28;
		private int emaxDay = 29;

		private int[] validMonths = new int[1] { 2 };

		public bool ValidateDay(int year, int month, int day)
		{
			return (validMonths.Any(number => number == month)) && (minDay <= day) &&	(((day <= maxDay)	&&	(year%4!=0))||(((day <= emaxDay)	&&	(year%4==0))));
		}
	}
}
