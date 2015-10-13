<?php

class Finnish extends Person
{
	private  $regex = '/\d{6}[+-A]\d{3}[0123456789ABCDEFHJKLMNPRSTUVWXY]/';

	protected $nationality = "Finland";



	public  function CheckMe()
	{
		if(preg_match($this->regex, $this->idNumber) && $this->CheckSum($this->idNumber))
			return true;
		else
			return false;

	
	}
	private function CheckSum()	
	{
		$control_value = "0123456789ABCDEFHJKLMNPRSTUVWXY";
		$len = strlen($this->idNumber)-1;
		$val = 0;

		for ($i=0; $i < $len; $i++) { 
			
			$val *= 10;
			if($i == 6) $i++;
			$val += $this->idNumber[$i];
		}
		$val %= 31;

		if($control_value[$val] == $this->idNumber[$len])
			return true;
		else 
			return false;
	}
	protected  function GetSexValue()
	{
		$len = strlen($this->idNumber)-1;

		return substr($this->idNumber, 7,3);
	}
	public function PersonSex()
	{
		$odd = $this->number->AmIOdd($this->GetSexValue());
		if($odd)
			return "Male";
		else
			return "Female";
	}

}
?>