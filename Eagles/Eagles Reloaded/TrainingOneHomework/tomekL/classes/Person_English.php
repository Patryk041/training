<?php 



class Person_English extends Person
{
//LL NN NN NN L
	public function __construct($nationality, $nationalNumber)
	{
		parent::__construct($nationality, $nationalNumber);
		$this->regExPattern = "/^[A-Z]{2}[0-9]{6}[a-zA-Z]{2}+$/";
	}

	function getSex()
	{
		return "It is impossible to determine sex on the basis of National Insurance Nubmer";
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