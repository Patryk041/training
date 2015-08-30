<?php
require_once 'Pesel.php';
require_once 'interfaces/Person.php';

class Gender extends Pesel implements Person
{
	private $gender;

	public function __construct($pesel)
	{
		parent::__construct($pesel);
		$this->gender = $this->cutPesel(9,1);
	}

	public function checkGender()
	{
		
		$man = [1,3,5,7,9];

		if(in_array($this->gender,$man) )
		{
			return true;
		}
		return false;		
	}

	public function printOut()
	{
		if(self::checkGender())
		{
			echo '<b>male </b>';
		}
		else
		{
			echo '<b>female </b>';
		}
	}
}


