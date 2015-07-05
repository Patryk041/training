<?php
//require_once '../GhostRider/Homework/StringOperationsObj.php';

class ObywatelGCCStringOperability extends GhostRiderStringOperability
{
	public function StringLength($string)
	{
		$len = 0;
		for($i = 0; isset($string[$i]); $i++)
		{
			$len++;
		}
		return $len;
	}
	
	public function SubString($string, $length)
	{
		$wynik = '';
		for($i = 0; $i < $length; $i++)
		{
			$wynik .= $string[$i];
		}
		return $wynik;
	}
	
	public function GetNick()
	{
		return 'ObywatelGCC';
	}
}