<?php
class English extends Person
{
	private $regex = '/^(?!BG|GB|NK|KN|TN|NT|ZZ)[ABCEGHJ-PRSTW-Z][ABCEGHJ-NPRSTW-Z]\d{6}[A-D]$/';
	protected $nationality = "England";



	public  function CheckMe()
	{
		if(preg_match($this->regex, $this->idNumber))	
			return true;
		else
			return false;
	}
	public  function GetSexValue()
	{

	}
	public function PersonSex(){

	}


}