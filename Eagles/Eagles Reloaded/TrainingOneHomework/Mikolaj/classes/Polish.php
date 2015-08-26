<?php
class Polish extends Person
{

	private $regex = '/^(\d{11})+$/';
	protected $nationality = "Poland";



	public function CheckMe()
	{
		if(preg_match($this->regex, $this->idNumber) && $this->CheckSum($this->idNumber))
			return true;
		else
			return false;
	}
	protected function CheckSum()
	{
		$len = strlen($this->idNumber)-1; 

		$j=1; $checkSum=0;

		for($i= 0; $i < $len; $i++, $j+=2)
		{
			if($j>9) $j = 1; else if($j==5) $j+=2;

			$checkSum += $this->idNumber[$i]*$j;

		}
	
		$checkSum = $checkSum % 10;
		

		if(($this->idNumber[$len]) == (10-$checkSum)%10)
			return true;
		else 
			return false;
	}
	protected function GetSexValue()
	{
		return $this->idNumber[strlen($this->idNumber)-2];
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