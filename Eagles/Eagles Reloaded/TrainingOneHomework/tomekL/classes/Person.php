<?php



 abstract class Person implements IPerson 
{

	protected $nationality ;
	protected $nationalNumber ;
	protected $regExPattern ;

	public function __construct($nationality, $nationalNumber)
	{

		$this->nationality  = $nationality;
		$this->nationalNumber = $nationalNumber;

	}

	final function getNationality()
	{
		return $this->nationality;
	}

	function getNationalNumber()
	{
		return $this->nationalNumber;
	}
	
	abstract function getSex();



	abstract function validate();

	

}



