<?php

class DziusioStringOperability extends GhostRiderStringOperability
	{
		public function  StringLength($string)
		{
			$wynik=0;
			for($i=0;isset($string);$i++)
			{
			$wynik+=1;
			}
			return $wynik;
		}
		
		public function SubString($string, $length)
		{
			$wynik='';
			for($i=0;$i<$length;$i++)
			{
			$wynik .= $string[$i];
			}
			return $wynik;
		}
		
		public function GetNick()
		{
			return "Dziusio";
		}
	}