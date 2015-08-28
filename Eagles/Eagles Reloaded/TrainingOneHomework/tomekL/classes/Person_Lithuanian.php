<?php

//G YYMMDD NNN C, where G is gender & birth century, YYMMDD is the birthday, NNN is a serial number, C is a checksum digit.

class Person_Lithuanian extends Person
{

	public function __construct($nationality, $nationalNumber)
	{
		parent::__construct($nationality, $nationalNumber);
		$this->regExPattern = "/^[0-9]{11}+$/";
	}
	
	function getSex()
	{
		return 0;
	}

	function getAge()
	{

		return 0;
	}

	

	function validate()
	{
		if (preg_match( $this->regExPattern,$this->nationalNumber))
		{
			return true;
		}
		else
		{
			return false;
		}
	}

}