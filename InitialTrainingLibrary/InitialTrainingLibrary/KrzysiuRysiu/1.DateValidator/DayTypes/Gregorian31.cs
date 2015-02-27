using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.KrzysiuRysiu._1.DateValidator.Interfaces;

namespace InitialTrainingLibrary.KrzysiuRysiu._1.DateValidator.DayTypes
{
	class Gregorian31 : IDayType
	{
		public bool ValidateDay()
		{
			return true;
		}
	}
}
