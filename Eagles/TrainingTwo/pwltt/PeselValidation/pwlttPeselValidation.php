<?php
require_once'../../GhostRider/Homework/PeselValidation.php';
require_once 'CutOffDate.php';
require_once 'DateValidation.php';

class pwlttPeselValidation extends	PeselValidation
{
	protected function DateValidation($year, $month, $day)
	{
		$DateValidator = new $DateValidation();
		
		
		
	}
	protected function CutOffDate($pesel)
	{
		$date = new CutOffDate();
		
		
	}
	
	protected function CheckSum($pesel)
	{
		$check = new Check();
		
		
	}
	public function ValidatePesel($pesel)
	{
		
		
		
	}
	
}