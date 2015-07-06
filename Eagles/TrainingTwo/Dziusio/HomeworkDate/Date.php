<?php
class Date
{
	$ArrayDay1 = new Array{31,28,31,30,31,30,31,31,30,31,30,31};
	$ArrayDay2 = new Array{31,29,31,30,31,30,31,31,30,31,30,31};
	

	
	function YearLeast($year, $month, $day)
	{	
		$YearAll=0;
		if (Month($year, $month, $day)==true)
		{
			$YearAll=Year($year, $month, $day);
		}
		if ($YearAll %4 ==0 && $YearAll % 100 != 0 || $YearAll % 400 == 0)
		{
			return true;
		}
		else 
		{
			return false;
		}
	}

	function Month($year, $month, $day)
	{
		$variable = MonthOfYears($year, $month, $day);
		if ( $variable>= 1 && $variable <= 12)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
	
	function MonthOfYears($year, $month, $day)
	{
		for($i=0;$i<=5;$i++)
		{		$i=$i*20;
			if ($month >= ($+1) && $month <=($i+12)
					{
						return $month-$i;
					}
			if ($i==5)
			{
				return 0;
			}
		}
	}
	
	
	function Year($year, $month, $day)
	{
		for($i=0;$i<=5;$i++)
		{
		$i=$i*20;
		if ($month >= ($i+1) && $month <=($i+12)
		{
		switch ($i) {
    case 0:
        return 1900+$year;
        break;
    case 20:
    	return 2000+$year;
        break;
    case 40:
        return 2100+$year;
        break;
    case 60:
        return 2200+$year;
        break;      
    case 80:
       	return 1800+$year;
       	break;

		}
		}
		}
	}
	
	function Day($year, $month, $day)
	{
		if (Month($year, $month, $day)==true)
		{
			$WhichMonth=MonthOfYears($year, $month, $day);
			
			if (YearLeast($year, $month, $day) == true)
			{
				if ($ArrayDay2[$WhichMonth-1] == $day)
				{
					return true;
				}
				else
				{
					return false;
				}
				
				
			}
			else 
			{
			
				if ($ArrayDay1[$WhichMonth-1] == $day)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}
		
		
	}
	
}
