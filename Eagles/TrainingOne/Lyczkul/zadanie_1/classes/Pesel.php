<?php

abstract class Pesel
{
	protected $pesel;
	/**
	 * checking if the variable $pesel is 11 characters
	 */
	public function __construct($pesel)
	{
		
		if(strlen($pesel)==11)
			$this->pesel = $pesel;
		else
			echo 'BadPesel !!!';
	}

	public function cutPesel($start,$length)
	{
		$var = substr($this->pesel,$start,$length);
		return $var;
	}
}