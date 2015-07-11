<?php
require_once '../../../TrainingOne/Dziara/function.php';


class ExtractDate
{
	protected function FormatString($string)
	{
		if($string[0] == 0 || $string[0] == 2)
		{
			return $string[1];
		}
		if($string[0] == 3)
		{
			$string[0] = 1; 
		}
		
		return $string;
	}
	
	protected function DetermineYer($string)
	{
		$tmp_date = Dziara_substr2($string, 2, 1);
		
		if($tmp_date == 0 || $tmp_date == 1)
		{
			return '19'.Dziara_substr($string, 2);
		}
		else if($tmp_date == 2 || $tmp_date == 3)
		{
			return '20'.Dziara_substr($string, 2);
		}
		
		return '0000';
	}
	
	protected function DetermineMonth($string)
	{		
		return $this->FormatString(Dziara_substr2($string, 2, 2));
	}
	
	protected function DetermineDay($string)
	{
		return $this->FormatString(Dziara_substr2($string, 4, 2));
	}
	
	protected function PerformOperations($pesel)
	{
		return array(
				'day' => $this->DetermineDay($pesel),
				'month' => $this->DetermineMonth($pesel),
				'year' => $this->DetermineYer($pesel),
			);
	}
	
	public function CutDate($pesel)
	{
		return $this->PerformOperations($pesel);
	}
}


//$t = new ExtractDate();
//print_r($t->CutDate('93560312455'));

