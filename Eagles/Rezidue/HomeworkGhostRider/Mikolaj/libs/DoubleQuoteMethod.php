<?php

/**
* 
*/
class DoubleQuoteMethod extends PhpToJava
{
	protected $buffor = '';
	function __construct(JavaCode $translated)
	{
		$this->translated = &$translated;


		$this->slownik = array(
			'"'   => array("wpisz"   => '"',  "stop" => '"'), 
		);
		
	}
}