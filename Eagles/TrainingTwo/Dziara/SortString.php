<?php
class SortString{
	
	static function Sort($string)
	{
		for($i = 0; $i < Dziara_strlen($string)-1; $i++)
		{
			for($j = 0; $j < Dziara_strlen($string)-1; $j++)
			{
				if($string[$j] > $string[$j+1])
				{
					$tmp = $string[$j];
					$string[$j]  = $string[$j+1];
					$string[$j+1] = $tmp;
				}
			}
		}
		return $string;
	}
	
}