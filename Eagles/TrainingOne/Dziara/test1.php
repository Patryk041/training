<?php
class Matka{
	public $zmienna = "To To tO";
	protected $inna = "protected";
	private $niewidoczna = " nie widoczna";
	
	public function __construct()
	{
			
	}
}

class Dziecko extends Matka
{
	public function test() 
	{
		echo $this->zmienna;
	}
}

class IamStatic
{
	static function Test()
	{
		echo 'Dupa..';
	}
}

