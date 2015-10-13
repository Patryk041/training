<?php
require_once'../../GhostRider/Homework/PeselValidation.php';
require_once 'ExtractDate.php';
require_once 'DateValidation.php';

class DziaraPeselValidation extends	PeselValidation
{
	protected function DateValidation($year, $month, $day)
	{
		$dateValidator = new DateValidation();
		
		return $dateValidator->Validation($year, $month, $day); 
	}
	
	protected function CutOffDate($pesel)
	{
		$extractDate = new ExtractDate();
		
		return $extractDate->CutDate($pesel);//array
	}
	
	protected function CheckSum($pesel)
	{
		$check_sum = new CheckSumPesel();
		
		return $check_sum->Check($pesel);
	}
	
	public function ValidatePesel($pesel)
	{
		$date = $this->CutOffDate($pesel);
		print_r($date);
		return $this->DateValidation($date['year'], $date['month'], $date['day']);
	}
}


//$test = new DziaraPeselValidation();

//echo 'result: '.$test->ValidatePesel('11302845081');