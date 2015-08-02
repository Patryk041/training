<?php
class DateValidation
{
	const MinMonth = 1;
	const MaxMonth = 12;
	const MinDay = 1;
	private $MaxDays = array(
			1 => 31,
			2 => array("nieprzestepny" => 28,"przestepny" => 29),
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
	protected function CzyPrzestepny($rok)
	{
		if( ($rok % 4 == 0 && $rok % 100 != 0) || ($rok % 400 == 0) )
		{
			return true;
		}
		return false;
	}
	protected function JakiMiesiac($miesiac)
	{
		return $miesiac>=1  &&  $miesiac <= 12;
	}
	protected  function JakiDzien($dzien)
	{
		
		
		
	}
	
}