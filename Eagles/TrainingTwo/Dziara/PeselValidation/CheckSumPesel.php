<?php
require_once '../../../TrainingOne/Dziara/function.php';

class CheckSumPesel
{
	
	protected function CountCheckSum($pesel)
	{
		$check_sum = 	$pesel[0] *1 
						+$pesel[1]*3
						+$pesel[2]*7
						+$pesel[3]*9
						+$pesel[4]*1
						+$pesel[5]*3
						+$pesel[6]*7
						+$pesel[7]*9
						+$pesel[8]*1
						+$pesel[9]*3;
		
		return $check_sum;
						
	}
	protected function ReturnCheckDigit($pesel)
	{
		$checkSum = (string)$this->CountCheckSum($pesel);
		
		return $checkSum[Dziara_strlen($checkSum) - 1];
	}
	
	public function Check($pesel)
	{
		return $this->ReturnCheckDigit($pesel) == $pesel[Dziara_strlen($pesel) - 1];
	}
}
