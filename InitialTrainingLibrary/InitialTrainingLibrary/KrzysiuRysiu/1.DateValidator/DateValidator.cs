using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces;
using InitialTrainingLibrary.KrzysiuRysiu._1.DateValidator.DayTypes;
using InitialTrainingLibrary.KrzysiuRysiu._1.DateValidator.MonthTypes;

namespace InitialTrainingLibrary.KrzysiuRysiu._1.DateValidator
{
	public class DateValidator	:IDateValidator
	{
		Gregorian30 g30 =new Gregorian30();
		Gregorian31 g31 = new Gregorian31();
		GregorianException gE = new GregorianException();
		GregorianMonths gM = new GregorianMonths();

	    public bool DateValidate(int year, int month, int day)
	    {
		    return gM.ValidateMonth(month) && ((g30.ValidateDay(year, month, day))	||	(g31.ValidateDay(year, month, day))	||	(gE.ValidateDay(year, month, day)));
	    }

	    public string GetName()
	    {
			return "KrzysiuRysiu";
	    }
		
	}
}
