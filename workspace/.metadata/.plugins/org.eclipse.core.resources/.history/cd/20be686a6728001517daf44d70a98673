<?php
class DateValidation
{
	const MIN_MONTH = 1;
	const MAX_MONTH = 12;
	const MIN_DAY = 1;
	
	private $MonthDay = array(
			1 => 31,
			2 => array(28,29),
			3 => 31,
			4 => 30,
			5 => 31,
			6 => 30,
			7 => 31,
			8 => 30,
			9 => 31,
			10 => 30,
			11 => 31,
			12 => 30,
	);
	
	protected function IsLeapYer($yer)
	{
		if( ($yer % 4 == 0 && $yer % 100 != 0) || ($yer % 400 == 0) )
		{
			return true;
		}
		
		return false;
	}
	
	protected function ValidMonth($month)
	{
		return $month >= 1 && $month <= 12;
	}
	
	protected function ValidDay($day, $month, $yer)
	{
		if($month == 2 && $this->IsLeapYer($yer) )
		{
			return $day >= 1 && $this->MonthDay[$month][1] >= $day;
		}
		else if($month == 2)
		{
			return $day >= 1 && $this->MonthDay[$month][0] >= $day;
		}
			
		return $day >= 1 && $this->MonthDay[$month] >= $day;
	}
	
	public function Validation($yer, $month,$day)
	{
		return $this->ValidMonth($month) && $this->ValidDay($day, $month, $yer);
	}
}


