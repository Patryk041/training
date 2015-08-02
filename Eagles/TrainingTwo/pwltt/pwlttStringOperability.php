<?php

class pwlttStringOperability extends GhostRiderStringOperability
{
	public function StringLength($string)
	{
		$count = 0;
		for($i = 0; isset($text[$i]); $i++)
		{
			$count++;
		}
		return $count;
	}
	public function SubString($string, $length)
	{
		$wynik = '';
		
		for( $i = 0; $i <=$count; $i++)
		{
			$wynik .= $text[$i];
		}
		
		return $wynik;
	}
	public function GetNick()
	{
		return 'pwltt';
	}
}