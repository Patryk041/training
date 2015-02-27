using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.KrzysiuRysiu._1.DateValidator.Interfaces;

namespace InitialTrainingLibrary.KrzysiuRysiu._1.DateValidator.DayTypes
{
	public class Gregorian30 : IDayType
	{
		private int minDay = 1;
		private int maxDay = 30;
		private int[] validMonths = new int[4] { 4, 6, 9, 11 };

		public bool ValidateDay(int year, int month, int day)
		{
			return (minDay <= day && day <= maxDay) && (validMonths.Any(number => number == month));
		}
	}
}
