<?php

/**
* 
*/
class EchoMethod extends PhpToJava
{
	protected $buffor = ')';
	function __construct(JavaCode $translated)
	{
		$this->translated = &$translated;


		$this->slownik = array(
			"echo" => array("wpisz"   => "\nSystem.out.println (", "stop" => ";"), 
			";"    => array("wpisz"   => ";",   "stop" => ""), 
			"."    => array("wpisz"   => "+",   "stop" => ""), 
			"$"    => array("wpisz"   => "",    "stop" => ""),
			")"    => array("wpisz"   => ")",   "stop" => ""),
			"("    => array("wpisz"   => "(",   "stop" => ""),
			"\""   => array("ExternalTranslateMethod" => "DoubleQuoteMethod"),

		//	"\""=>array("wpisz"  => "\"",  "stop" => "")
		);
	
	}

}