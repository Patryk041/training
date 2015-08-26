<?php

/**
* 
*/
abstract class Person implements Identity
{
	protected   $nationality;
    protected   $idNumber;
    protected   $number;

	function __construct($idNumber)
    {
        $this->idNumber = $idNumber;
        $this->number = new Number(); //instance of class responsible for numbers calculation
    }

	abstract protected  function GetSexValue();
	abstract public  function PersonSex();

	public function PersonInfo()
    {
    	echo "<b>ID</b>: <label style='color:green; font-style:italic;'>".   $this->idNumber     ."</label>
    	<b>Nationality</b>: <label style='color:green; font-style:italic;'>".$this->nationality  ." </label>
    	<b>Sex</b>: <label style='color:green; font-style:italic;'>".        $this->PersonSex()  ."</label><br>";
    }
}