<?php

class jakeStringOperability extends GhostRiderStringOperability
{
	public function SubString($string, $length)
	{
		$result = '';
		for ($i = 0; $i <= $lenght; $i++)
		{
			$result.=$string[$i];
		}
		
		return $result;
	}
	
	
	public function StringLength($string)
	{
		for($i = 0; isset($string[$i]); $i++)
		{
			$count++;
		}
		
		return $count;
	}
	
	public function GetNick()
	{
		return 'jake';
	}
}
